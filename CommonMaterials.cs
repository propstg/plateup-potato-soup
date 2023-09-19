using KitchenLib.Utils;
using UnityEngine;

namespace PotatoSoup {
    public class CommonMaterials {
        private static Material[] wrap(Material material) => new Material[] { material };

        public static Material[] metalShiny => wrap(MaterialUtils.GetExistingMaterial("Metal- Shiny"));
        public static Material[] eggDough => wrap(MaterialUtils.GetExistingMaterial("Egg Dough"));
        public static Material[] milk => wrap(MaterialUtils.GetExistingMaterial("Coffee Cup"));
        public static Material[] potatoes => wrap(MaterialUtils.GetExistingMaterial("Sack"));
        public static Material[] foam => wrap(MaterialUtils.GetExistingMaterial("Uncooked Batter"));
    }
}
