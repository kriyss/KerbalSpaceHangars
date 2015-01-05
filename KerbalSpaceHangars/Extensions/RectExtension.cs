using UnityEngine;

namespace KerbalSpaceHangars.Extensions {
    public static class RectExtension {
        public static Rect CenterScreen(this Rect rect) {
            return  new Rect(rect) {x = Screen.width / 2 - rect.width/2, y = Screen.height/2 - rect.height/2};
        }
    }
}
