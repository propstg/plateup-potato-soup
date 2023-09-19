using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace PotatoSoup.custom {

    public class PotatoSoupPlainServing : CustomItem {

        public override string UniqueNameID => "Potato Soup Plain Serving";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoesInMilkCooked");
        public override string ColourBlindTag => "Ps";

        public override void OnRegister(Item gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "pot", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/foam", CommonMaterials.foam);
        }
    }
}
