using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;

namespace blargle.PotatoSoup.custom {

    public class PotatoSoupPeppersDish : CustomDish {

        public override string UniqueNameID => "Potato Soup Peppers Dish";
        public override DishType Type => DishType.Extra;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override bool IsAvailableAsLobbyOption => false;
        public override bool RequiredNoDishItem => true;

        public override List<Unlock> HardcodedRequirements => new List<Unlock> {
            Refs.PotatoSoupMainDish
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item> {
            Refs.Peppers
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string> {
            { Locale.English, "Add chopped peppers to a bowl of potato soup. May combine with other additions." }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)> {
            { (Locale.English, LocalisationUtils.CreateUnlockInfo("Potato Soup w/Peppers", "Spice up your potato soup.", "") )}
        };
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock> {
            new Dish.IngredientUnlock() {
                MenuItem = Refs.PotatoSoupServing,
                Ingredient = Refs.ChoppedPeppers,
            },
        };

        public override void OnRegister(Dish gdo) {
            gdo.Difficulty = 1;
        }
    }
}
