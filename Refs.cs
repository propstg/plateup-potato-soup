using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using PotatoSoup.custom;

namespace PotatoSoup
{

    public class Refs {

        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Potato => (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato);
        public static Item Milk => (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk);
        public static Item Flour => (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour);
        public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
        public static Item EggDough => GDOUtils.GetCastedGDO<Item, EggDough>();
        public static Item PotatoChoppedPotCooked => (Item)GDOUtils.GetExistingGDO(ItemReferences.PotatoChoppedPotCooked);

        public static Process CookProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process ChopProcess => (Process) GDOUtils.GetExistingGDO(ProcessReferences.Chop);

        public static Item PotatoesInMilkCooked => GDOUtils.GetCastedGDO<Item, PotatoesInMilkCooked>();
        public static Item PotatoesInMilkUncooked => GDOUtils.GetCastedGDO<Item, PotatoesInMilkUncooked>();
        public static Item PotatoSoupPlainUncooked => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainUncooked>();
        public static Item PotatoSoupPlainCooked => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainCooked>();
        public static Item PotatoSoupPlainServing => GDOUtils.GetCastedGDO<Item, PotatoSoupPlainServing>();
    }
}
