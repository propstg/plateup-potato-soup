using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using static KitchenData.ItemGroup;

namespace PotatoSoup.custom {

    public class PotatoSoupPlainUncooked : CustomItemGroup<PotatoSoupPlainUncooked.PotatoSoupPlainUncookedItemGroupView> {

        public override string UniqueNameID => "Potato Soup Plain Uncooked";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoesInMilkCooked");
        public override string ColourBlindTag => "Ps";
        public override Item DisposesTo => Refs.Pot;

        public override List<ItemSet> Sets => new List<ItemSet>() {
            new ItemSet() {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>() {
                    Refs.PotatoesInMilkCooked,
                },
            },
            new ItemSet() {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>() {
                    Refs.EggDough,
                },
            },
            new ItemSet() {
                Max = 1,
                Min = 1,
                Items = new List<Item>() {
                    Refs.EggDough,
                },
            },
            new ItemSet() {
                Max = 1,
                Min = 1,
                Items = new List<Item>() {
                    Refs.EggDough,
                },
            },
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess> {
            new Item.ItemProcess {
                Duration = 10f,
                IsBad = false,
                Process = Refs.CookProcess,
                Result = Refs.PotatoSoupPlainCooked,
            }
        };

        public override void OnRegister(ItemGroup gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "pot", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/foam", CommonMaterials.foam);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-0", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-1", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(Prefab, "ingredients/dumplings-2", CommonMaterials.eggDough);

            Prefab.GetComponent<PotatoSoupPlainUncookedItemGroupView>()?.Setup(Prefab);
        }

        public class PotatoSoupPlainUncookedItemGroupView : ItemGroupView {
            internal void Setup(GameObject prefab) {
                ComponentGroups = new List<ComponentGroup>() {
                    new ComponentGroup() {
                        Item = Refs.PotatoesInMilkCooked,
                        Objects = new List<GameObject> {
                            GameObjectUtils.GetChildObject(prefab, "pot"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/foam"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/liquid"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/potatoes"),
                        },
                        DrawAll = true,
                    },
                    new ComponentGroup() {
                        Item = Refs.EggDough,
                        Objects = new List<GameObject> {
                            GameObjectUtils.GetChildObject(prefab, "ingredients/dumplings-0"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/dumplings-1"),
                            GameObjectUtils.GetChildObject(prefab, "ingredients/dumplings-2"),
                        },
                    },
                };
            }
        }
    }
}
