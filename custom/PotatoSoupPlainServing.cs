using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace PotatoSoup.custom {

    public class PotatoSoupPlainServing : CustomItem {

        public override string UniqueNameID => "Potato Soup Plain Serving";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoSoupServing");
        public override string ColourBlindTag => "Ps";

        public override void OnRegister(Item gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "bowl", CommonMaterials.bowl);
            MaterialUtils.ApplyMaterial(Prefab, "liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(Prefab, "potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(Prefab, "dumplings", CommonMaterials.eggDough);
        }
    }
}
