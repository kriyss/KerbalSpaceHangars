using System;
using UnityEngine;

namespace KerbalSpaceHangars
{
    public enum SkinList
    {
		FlagBrowser,
		Window1,
		Window2,
		Window3,
		Window4,
		Window5,
		Window6,
		Window7,
		OrbitMap,
		PlaqueDialog,
		Default
	
    }

    public enum StyleList
    {
        Button,
        Default,
        HorizontalSlider,
        HorizontalSliderThumb,
        Label,
        Textbox,
        TextArea,
        Toggle,
        VerticalSlider,
        VerticalSliderThumb,
        Window
    }

    public class Const
	{
        public static GUISkin GetSkin(SkinList skin)
		{
		    String skinS = "";
			switch(skin) {
			    case SkinList.FlagBrowser:  skinS = "FlagBrowserSkin";  break;
			    case SkinList.Window1:      skinS = "KSP window 1";     break;
			    case SkinList.Window2:      skinS = "KSP window 2";     break;
			    case SkinList.Window3:      skinS = "KSP window 3";     break;
			    case SkinList.Window4:      skinS = "KSP window 4";     break;
			    case SkinList.Window5:      skinS = "KSP window 5";     break;
			    case SkinList.Window6:      skinS = "KSP window 6";     break;
			    case SkinList.Window7:      skinS = "KSP window 7";     break;
			    case SkinList.OrbitMap:     skinS = "OrbitMapSkin";     break;
			    case SkinList.PlaqueDialog: skinS = "PlaqueDialogSkin"; break;
			    case SkinList.Default:      skinS = "Default";          break;
			}
            Debug.LogError("skin : " + skinS);
			return AssetBase.GetGUISkin(skinS);
		}
    }
}