using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace blargle.PotatoSoup.custom {

    public class PotatoSoupPlainDish : CustomDish {

        public override string UniqueNameID => "Potato Soup Plain Dish";
        public override DishType Type => DishType.Base;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override GameObject DisplayPrefab => Main.bundle.LoadAsset<GameObject>("PotatoSoupPlainCard");
        public override GameObject IconPrefab => Main.bundle.LoadAsset<GameObject>("PotatoSoupPlainCard");

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override bool IsAvailableAsLobbyOption => false;
        public override bool RequiredNoDishItem => true;
        public override List<string> StartingNameSet => new List<string> {
            "POTATO SOUP",
            "Potato Pantry",
            "Dumpling Dreamland",
            "Denrast Dumplings",
            "Tateresa",
            "Samwise Special",
        };

        public override List<Unlock> HardcodedBlockers => new List<Unlock> {
            Refs.PotatoSoupMainDish
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock> {
            Refs.PotatoSoupLegacyDish
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item> {
            Refs.Pot,
            Refs.Potato,
            Refs.Milk,
            Refs.Flour,
            Refs.Egg,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process> {
            Refs.RequireOven,
        };

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>() {
            new Dish.MenuItem() { Phase = MenuPhase.Main, Item = Refs.PotatoSoupServing, Weight = 1 },
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string> {
            { Locale.English, "1. Chop potatoes and add to pot with water and cook\n2. Add milk and cook\n3. Crack egg and mix with flour, add to pot, cook.\n4. Serve." }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)> {
            { (Locale.English, LocalisationUtils.CreateUnlockInfo("Potato Soup (Legacy)", "Outdated. Create a new restaurant to get access to toppings.", "") )}
        };

        public override void SetupIconPrefab(GameObject prefab) {
            setupCommonDisplayPrefab(prefab);
        }

        public override void SetupDisplayPrefab(GameObject prefab) {
            setupCommonDisplayPrefab(prefab);
        }

        private void setupCommonDisplayPrefab(GameObject prefab) {
            MaterialUtils.ApplyMaterial(prefab, "pot", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(prefab, "ingredients/dumplings-0", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(prefab, "ingredients/dumplings-1", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(prefab, "ingredients/dumplings-2", CommonMaterials.eggDough);
            MaterialUtils.ApplyMaterial(prefab, "ingredients/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(prefab, "ingredients/potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(prefab, "PotatoSoupServing/bowl", CommonMaterials.metalShiny);
            MaterialUtils.ApplyMaterial(prefab, "PotatoSoupServing/liquid", CommonMaterials.milk);
            MaterialUtils.ApplyMaterial(prefab, "PotatoSoupServing/potatoes", CommonMaterials.potatoes);
            MaterialUtils.ApplyMaterial(prefab, "PotatoSoupServing/dumplings", CommonMaterials.eggDough);
        }

        public override void OnRegister(Dish gdo) {
            gdo.Difficulty = 2;
        }
    }
}
