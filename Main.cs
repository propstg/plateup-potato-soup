using Kitchen;
using KitchenLib;
using KitchenMods;
using PotatoSoup.custom;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace PotatoSoup
{

    public class Main : BaseMod {

        public const string MOD_ID = "blargle.PotatoSoup";
        public const string MOD_NAME = "Potato Soup";
        public const string MOD_VERSION = "0.0.0";
        public const string MOD_AUTHOR = "blargle";

        public static AssetBundle bundle;

        public Main() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, ">=1.1.7", Assembly.GetExecutingAssembly()) { }

        protected override void OnPostActivate(Mod mod) {
            Log($"v{MOD_VERSION} initialized");
            Log($"Loading asset bundle...");
            bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).First();
            Log($"Asset bundle loaded.");

            AddGameDataObject<PotatoesInMilkUncooked>();
            AddGameDataObject<PotatoesInMilkCooked>();
            AddGameDataObject<PotatoSoupPlainUncooked>();
            AddGameDataObject<PotatoSoupPlainCooked>();
            AddGameDataObject<PotatoSoupPlainServing>();
            AddGameDataObject<PotatoSoupPlainDish>();
        }

        public static void Log(object message) {
            Debug.Log($"[{MOD_ID}] {message}");
        }
    }
}
