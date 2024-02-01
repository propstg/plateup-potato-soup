using KitchenLib.Utils;
using UnityEngine;

namespace blargle.PotatoSoup {

    public class CommonMaterials {

        public static Material[] metalShiny => wrap(MaterialUtils.GetExistingMaterial("Metal- Shiny"));
        public static Material[] bowl => wrap(MaterialUtils.GetExistingMaterial("Wallpaper - Stripes Red"));
        public static Material[] eggDough => wrap(MaterialUtils.GetExistingMaterial("Raw Potato"));
        public static Material[] milk => wrap(MaterialUtils.GetExistingMaterial("Milk"));
        public static Material[] potatoes => wrap(MaterialUtils.GetExistingMaterial("Cooked Potato"));
        public static Material[] foam => wrap(MaterialUtils.GetExistingMaterial("Uncooked Batter"));
        public static Material[] cookedMilk => wrap(MaterialUtils.CreateFlat("PotatoSoup - Cooked Milk", 0xE8C878));
        public static Material[] cookedDumping => wrap(MaterialUtils.CreateFlat("PotatoSoup - Cooked Dumpling", 0xC08127));
        public static Material[] cheese => wrap(MaterialUtils.CreateFlat("PotatoSoup - CHEESE", 0xc98d00));
        public static Material[] pepper => wrap(MaterialUtils.CreateFlat("PotatoSoup - PEPPER", 0xff0000));
        public static Material[] broccoliCooked => wrap(MaterialUtils.GetExistingMaterial("Cooked Broccoli"));
 
        private static Material[] wrap(Material material) => new Material[] { material };
    }
}
