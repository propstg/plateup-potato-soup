using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace PotatoSoup.custom {

    public class PotatoSoupPlainCooked : CustomItem {

        public override string UniqueNameID => "Potato Soup Plain Cooked";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoSoupPlainCooked");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 1f;
        public override int SplitCount => 5;
        public override Item SplitSubItem => Refs.Potato;
        public override List<Item> SplitDepletedItems => new List<Item> { Refs.Pot };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;
        public override string ColourBlindTag => "Ps";

        public override void OnRegister(Item gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "pot", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-0", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-1", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-2", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/potatoes", CommonMaterials.potatoes);

            if (!Prefab.HasComponent<PlainPotatoSoupCookedView>()) {
                Prefab.AddComponent<PlainPotatoSoupCookedView>().Setup(Prefab);
            }
        }
    }

    public class PlainPotatoSoupCookedView : PositionSplittableView {

        internal void Setup(GameObject prefab) {
            var fullPositionField = ReflectionUtils.GetField<PositionSplittableView>("FullPosition");
            fullPositionField.SetValue(this, new Vector3(-0.26f, 0.1f, -0.19f));

            var emptyPositionField = ReflectionUtils.GetField<PositionSplittableView>("EmptyPosition");
            emptyPositionField.SetValue(this, new Vector3(-0.26f, -0.150f, -0.19f));

            var objectsField = ReflectionUtils.GetField<PositionSplittableView>("Objects");
            objectsField.SetValue(this, new List<GameObject>() {
                prefab.GetChild("ingredients")
            });
        }
    }
}
