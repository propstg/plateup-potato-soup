using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using static KitchenData.ItemGroup;

namespace blargle.PotatoSoup.custom {

    public class PotatoesInMilkUncooked : CustomItemGroup<PotatoesInMilkUncooked.PotatoesInMilkItemGroupView> {

        public override string UniqueNameID => "Potatoes In Milk Uncooked";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoesInMilkUncooked");
        public override string ColourBlindTag => "P";
        public override Item DisposesTo => Refs.Pot;

        public override List<ItemSet> Sets => new List<ItemSet>() {
            new ItemSet() {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>() {
                    Refs.PotatoChoppedPotCooked,
                },
            },
            new ItemSet() {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>() {
                    Refs.Milk,
                },
            },
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess> {
            new Item.ItemProcess {
                Duration = 10f,
                IsBad = false,
                Process = Refs.CookProcess,
                Result = Refs.PotatoesInMilkCooked
            }
        };

        public override void OnRegister(ItemGroup gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "pot", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/potatoes", CommonMaterials.potatoes);

            if (Prefab.TryGetComponent<ItemGroupView>(out var itemGroupView)) {
                itemGroupView.gameObject.transform.Find("Colour Blind").localPosition = new Vector3(0, 0.6f, 0);
            }

            Prefab.GetComponent<PotatoesInMilkItemGroupView>()?.Setup(Prefab);
        }

        public class PotatoesInMilkItemGroupView : ItemGroupView {
            internal void Setup(GameObject prefab) {
                ComponentGroups = new List<ComponentGroup> {
                    new ComponentGroup() {
                        Item = Refs.PotatoChoppedPotCooked,
                        Objects = new List<GameObject> {
                            GameObjectUtils.GetChildObject(prefab, "pot"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/potatoes"),
                        },
                        DrawAll = true,
                    },
                    new ComponentGroup() {
                        Item = Refs.Milk,
                        Objects = new List<GameObject> {
                            GameObjectUtils.GetChildObject(prefab, "ingredients/liquid"),
                        },
                        DrawAll = true,
                    },
                };
            }
        }
    }
}
