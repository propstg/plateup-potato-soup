using ApplianceLib.Api.Prefab;
using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using static KitchenData.ItemGroup;

namespace blargle.PotatoSoup.custom {

    public class PotatoSoupServing : CustomItemGroup<PotatoSoupServing.PotatoSoupServingItemGroupView> {

        public override string UniqueNameID => "Potato Soup Serving";
        public override GameObject Prefab => Main.bundle.LoadAsset<GameObject>("PotatoSoupServingPlain");
        public override ItemValue ItemValue => ItemValue.Medium;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override Item DisposesTo => null;
        public override Item DirtiesTo => null;


        public override void OnRegister(ItemGroup gameDataObject) {
            MaterialUtils.ApplyMaterial(Prefab, "bowl", CommonMaterials.bowl);
            MaterialUtils.ApplyMaterial(Prefab, "liquid", CommonMaterials.cookedMilk);
            MaterialUtils.ApplyMaterial(Prefab, "potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(Prefab, "dumplings", CommonMaterials.cookedDumping);
            MaterialUtils.ApplyMaterial(Prefab, "cheese", CommonMaterials.cheese);
            MaterialUtils.ApplyMaterial(Prefab, "asparagus1", CommonMaterials.broccoliCooked);
            MaterialUtils.ApplyMaterial(Prefab, "asparagus2", CommonMaterials.broccoliCooked);

            var choppedPeppers = (GDOUtils.GetCastedGDO<Item, ChoppedPepper>() as IHasPrefab)?.Prefab.transform.Find("Shaving0").gameObject;
            Prefab.AttachPrefabAsChild(choppedPeppers);
            Prefab.transform.Find("Shaving0(Clone)").transform.localPosition += new Vector3(0, 0.1f, -0.075f);
            MaterialUtils.ApplyMaterial(Prefab, "Shaving0(Clone)", CommonMaterials.pepper);

            Prefab.GetComponent<PotatoSoupServingItemGroupView>()?.Setup(Prefab);
        }

        public override List<ItemSet> Sets => new List<ItemSet>() {
            new ItemSet() {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>() {
                    Refs.PotatoSoupPlainServing,
                },
            },
            new ItemSet() {
                Max = 3,
                Min = 0,
                RequiresUnlock = true,
                Items = new List<Item>() {
                    Refs.Cheese,
                    Refs.ChoppedPeppers,
                    Refs.AsparagusFullCooked,
                }
            },
        };

        public class PotatoSoupServingItemGroupView : ItemGroupView {
            internal void Setup(GameObject prefab) {
                ComponentGroups = new List<ComponentGroup>() {
                    new ComponentGroup() {
                        Item = Refs.PotatoSoupPlainServing,
                        Objects = new List<GameObject>() {
                            GameObjectUtils.GetChildObject(prefab, "bowl"),
                            GameObjectUtils.GetChildObject(prefab, "liquid"),
                            GameObjectUtils.GetChildObject(prefab, "potatoes"),
                            GameObjectUtils.GetChildObject(prefab, "dumplings"),
                        },
                        DrawAll = true
                    },
                    new ComponentGroup() {
                        Item = Refs.Cheese,
                        Objects = new List<GameObject>() {
                            GameObjectUtils.GetChildObject(prefab, "cheese"),
                        }
                    },
                    new ComponentGroup() {
                        Item = Refs.ChoppedPeppers,
                        Objects = new List<GameObject>() {
                            GameObjectUtils.GetChildObject(prefab, "Shaving0(Clone)"),
                        }
                    },
                    new ComponentGroup() {
                        Item = Refs.AsparagusFullCooked,
                        Objects = new List<GameObject>() {
                            GameObjectUtils.GetChildObject(prefab, "asparagus1"),
                            GameObjectUtils.GetChildObject(prefab, "asparagus2"),
                        },
                        DrawAll = true,
                    },
                };

                ComponentLabels = new List<ColourBlindLabel>() {
                    new ColourBlindLabel() { Text = "Ps", Item = Refs.PotatoSoupPlainServing},
                    new ColourBlindLabel() { Text = "C", Item = Refs.Cheese},
                    new ColourBlindLabel() { Text = "P", Item = Refs.ChoppedPeppers},
                    new ColourBlindLabel() { Text = "A", Item = Refs.AsparagusFullCooked},
                };
            }
        }
    }
}
