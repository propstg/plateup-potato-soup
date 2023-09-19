using KitchenLib.Utils;
using UnityEngine;

namespace PotatoSoup {
    public class CommonMaterials {
        private static Material[] wrap(Material material) => new Material[] { material };

        public static Material[] metalShiny => wrap(MaterialUtils.GetExistingMaterial("Metal- Shiny"));
        public static Material[] bowl => wrap(MaterialUtils.GetExistingMaterial("Wallpaper - Stripes Red"));
        public static Material[] eggDough => wrap(MaterialUtils.GetExistingMaterial("Raw Potato"));
        public static Material[] milk => wrap(MaterialUtils.GetExistingMaterial("Milk"));
        public static Material[] potatoes => wrap(MaterialUtils.GetExistingMaterial("Cooked Potato"));
        public static Material[] foam => wrap(MaterialUtils.GetExistingMaterial("Uncooked Batter"));
    }
}
