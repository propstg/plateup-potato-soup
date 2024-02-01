using blargle.PotatoSoup.custom;
using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;

namespace blargle.PotatoSoup {

    public class Refs {

        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Potato => (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato);
        public static Item Milk => (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk);
        public static Item Flour => (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour);
        public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
        public static Item EggDough => GDOUtils.GetCastedGDO<Item, EggDough>();
        public static Item PotatoChoppedPotCooked => (Item)GDOUtils.GetExistingGDO(ItemReferences.PotatoChoppedPotCooked);
        public static Item Cheese => (Item) GDOUtils.GetExistingGDO(ItemReferences.Cheese);
        public static Item Peppers => GDOUtils.GetCastedGDO<Item, Pepper>();
        public static Item ChoppedPeppers => GDOUtils.GetCastedGDO<Item, ChoppedPepper>();
        public static Item Asparagus => GDOUtils.GetCastedGDO<Item, Asparagus>();
        public static Item BurnedFood => (Item) GDOUtils.GetExistingGDO(ItemReferences.BurnedFood);

        public static Process CookProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process ChopProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process RequireOven => (Process) GDOUtils.GetExistingGDO(ProcessReferences.RequireOven);

        public static Item PotatoesInMilkCooked => GDOUtils.GetCastedGDO<Item, PotatoesInMilkCooked>();
        public static Item PotatoesInMilkUncooked => GDOUtils.GetCastedGDO<Item, PotatoesInMilkUncooked>();
        public static Item PotatoSoupPlainUncooked => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainUncooked>();
        public static Item PotatoSoupPlainCooked => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainCooked>();
        public static Item PotatoSoupPlainServing => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainServing>();
        public static ItemGroup PotatoSoupServing => GDOUtils.GetCastedGDO<ItemGroup, PotatoSoupServing>();
        public static Dish PotatoSoupLegacyDish => GDOUtils.GetCastedGDO<Dish, PotatoSoupPlainDish>();
        public static Dish PotatoSoupMainDish => GDOUtils.GetCastedGDO<Dish, PotatoSoupMainDish>();
        public static Item AsparagusFullCooked => GDOUtils.GetCastedGDO<Item, AsparagusFullCooked>();
    }
}
