using UnityEngine;

namespace KerbalSpaceHangars.Utils
{
    public static class KshUtils {
        public static Texture2D GetTextureFromWww(string url) {
            var init = false;
            WWW tLoad = null;
            Texture2D texture = null;

            while (!init) {
                if (tLoad == null) {
                    Debug.Log("Beginning load at time: " + Time.time);
                    tLoad = new WWW(url);
                }
                else if (tLoad.isDone) {
                    Debug.Log("File has finished being loaded at " + Time.time);
                    texture = new Texture2D(0, 0, TextureFormat.DXT1, false);
                    tLoad.LoadImageIntoTexture(texture);
                    init = true;
                }
            }
            return texture;
        }
    }
}
