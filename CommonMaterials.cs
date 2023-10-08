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

        private static Material[] wrap(Material material) => new Material[] { material };
    }
}
