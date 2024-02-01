using blargle.PotatoSoup.custom;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Event;
using KitchenLib.Utils;
using KitchenMods;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace blargle.PotatoSoup {

    public class Main : BaseMod {

        public const string MOD_ID = "blargle.PotatoSoup";
        public const string MOD_NAME = "Potato Soup";
        public const string MOD_AUTHOR = "blargle";
        public static readonly string MOD_VERSION = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.ToString();

        public static AssetBundle bundle;

        public Main() : base(MOD_ID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, ">=1.1.8", Assembly.GetExecutingAssembly()) { }

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
            AddGameDataObject<PotatoSoupMainDish>();
            AddGameDataObject<PotatoSoupServing>();
            AddGameDataObject<PotatoSoupCheeseDish>();
            AddGameDataObject<PotatoSoupPeppersDish>();
            AddGameDataObject<PotatoSoupAsparagusDish>();
            AddGameDataObject<AsparagusFullCooked>();

            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args) {
                Log(IngredientLib.References.GetIngredient("asparagus"));
                if (args.gamedata.TryGet(IngredientLib.References.GetIngredient("asparagus"), out Item asparagus)) {
                    FieldInfo processesFieldInfo = ReflectionUtils.GetField<Item>("Processes");

                    var processes = (List<Item.ItemProcess>) processesFieldInfo.GetValue(asparagus);

                    processes.Add(new Item.ItemProcess {
                        Duration = 3f,
                        IsBad = false,
                        Process = Refs.CookProcess,
                        Result = Refs.AsparagusFullCooked,
                    });

                    processesFieldInfo.SetValue(asparagus, processes);
                }
            };
        }

        [Conditional("DEBUG")]
        public static void DebugLog(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            Log(message, callingFilePath, lineNumber, caller);
        }

        public static void Log(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            UnityEngine.Debug.Log($"[{MOD_ID}] [{caller}({callingFilePath}:{lineNumber})] {message}");
        }
    }
}
