using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace blargle.PotatoSoup.custom {

    public class AsparagusFullCooked : CustomItem {

        public override string UniqueNameID => "Asparagus Full Cooked";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("CookedAsparagus");
        public override string ColourBlindTag => "A";
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override void OnRegister(Item gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "asparagus1", CommonMaterials.broccoliCooked);
            MaterialUtils.ApplyMaterial(Prefab, "asparagus2", CommonMaterials.broccoliCooked);
        }

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess> {
            new Item.ItemProcess {
                Duration = 8f,
                IsBad = true,
                Process = Refs.CookProcess,
                Result = Refs.BurnedFood,
            }
        };
    }
}
