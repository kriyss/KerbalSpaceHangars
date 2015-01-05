using System;
using UnityEngine;
using System.Collections;
using KspFR_HangarMod.Utils;
using KspFR_HangarMod.Extensions;
using System.Collections.Generic;
using KspFR_HangarMod.Extensions;

namespace KspFR_HangarMod.UI
{
    class KerbalSpaceHangarGui {
        private const float MaxWidth        = 1200;
        private const float MaxHeight       = 700;
        private const float OffsetOutside   = 10; 
        private const float OffsetInside    = 3;
        private const float ButtonHeight    = 80;
         
        private readonly float _firstRectWidth  = MaxWidth / 3 - GetOffSet(0, 1);
        private readonly float _secondRectWidth = MaxWidth / 3 * 2 - GetOffSet(0, 2);

        private readonly Texture2D _fuseeIcon       = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/fusee_w",     false);
        private readonly Texture2D _navetteIcon     = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/navette_w",   false);
        private readonly Texture2D _stationIcon     = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/station_w",   false);
        private readonly Texture2D _avionIcon       = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/avion_w",     false);
        private readonly Texture2D _baseIcon        = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/base_w",      false);
        private readonly Texture2D _homeIcon        = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/home_w",      false);
        private readonly Texture2D _landerIcon      = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/lander_w",    false);
        private readonly Texture2D _roverIcon       = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/rover_w",     false);
        private readonly Texture2D _subassIcon      = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/subass_w",    false);
        private readonly Texture2D _sondeIcon       = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/sonde_w",     false);
        //private readonly Texture2D _btnDownload     = GameDatabase.Instance.GetTexture("kriyss/HangarMod/Assets/download_b",  false);

        private readonly Texture2D _firstImg;
        private readonly Texture2D _secImg;
        private readonly Texture2D _treImg;

        private const String Yellow = "#ffc600";
        private const String Green  = "#a7f20d";

        private List<Texture> _imageArray = new List<Texture>();
        private int _currentImage = 0;

        private Rect    _windowPosition = new Rect(OffsetOutside, OffsetOutside, MaxWidth, MaxHeight);
        private Vector2 _scrollPosition;

        public KerbalSpaceHangarGui() {
            _windowPosition = _windowPosition.CenterScreen();
            _firstImg = KshUtils.GetTextureFromWww("http://hangar.kerbalspaceprogram.fr/files/0f1f7955db6587573de452ff2d8c9725/c65a1ab0d3f429d04685196990c682e3/img/min/180/f58d577e8bb5ba031761477472b22258.jpg");
            _secImg = KshUtils.GetTextureFromWww("http://hangar.kerbalspaceprogram.fr/files/7de50059e2d0b736be80d6dfb64a15f4/ff2c10753433a56d667331d314c8c4e2/img/min/180/8148543ddbcbb12fc76c237d68ea60da.jpg");
            _treImg = KshUtils.GetTextureFromWww("http://hangar.kerbalspaceprogram.fr/files/7de50059e2d0b736be80d6dfb64a15f4/69d1ead2139e302613c02cb8b82e3b65/img/min/180/1b0fc1de91c123f8a45b71a23fb1c02c.jpg");
           
            _imageArray.Add(_firstImg);
            _imageArray.Add(_secImg);
            _imageArray.Add(_treImg);
        } 

        public void Draw() {
            GUI.skin = HighLogic.Skin;
            _windowPosition = GUI.Window(10, _windowPosition, OnWindow, "Kerbal Space Hangar");     
        }
        
        private void OnWindow(int windowsId) {
            GUILayout.BeginHorizontal(GUILayout.Width(MaxWidth));
                DrawLeftArea();
                DrawCenterArea();
                DrawRightArea();
            GUILayout.EndHorizontal();
            
            GUI.DragWindow();
        }
        
        private void DrawCenterArea() {
            GUI.skin.button.alignment = TextAnchor.MiddleLeft;
            GUI.skin.scrollView.margin = new RectOffset(0,0,0,0);
            GUI.skin.scrollView.padding = new RectOffset(0,0,0,0);

            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition, false, true, GUILayout.Width(_firstRectWidth));

            GUILayout.Button(new GUIContent(GetPrez("DC - Mendacium (Launcher)", "Dakitess", "5,0", "17"), _firstImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29", "Dragoon1010", "3,0", "9"), _treImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));
            GUILayout.Button(new GUIContent(GetPrez("Kig-29 SSTO", "Dragoon1010", "N/A", "17"), _secImg), GUILayout.Height(ButtonHeight), GUILayout.Width(_firstRectWidth - 28));

            GUILayout.EndScrollView();
             
        }

        private void DrawLeftArea() {
            GUILayout.BeginVertical(GUILayout.Width(40));
                GUILayout.Button(new GUIContent(_homeIcon,      "Accueil"));
                GUILayout.Button(new GUIContent(_sondeIcon,     "Sondes"));
                GUILayout.Button(new GUIContent(_fuseeIcon,     "Fusées"));
                GUILayout.Button(new GUIContent(_avionIcon,     "Avions"));
                GUILayout.Button(new GUIContent(_roverIcon,     "Rovers"));
                GUILayout.Button(new GUIContent(_navetteIcon,   "Vaisseaux"));
                GUILayout.Button(new GUIContent(_stationIcon,   "Stations"));
                GUILayout.Button(new GUIContent(_baseIcon,      "Bases"));
                GUILayout.Button(new GUIContent(_landerIcon,    "Lander"));
                GUILayout.Button(new GUIContent(_subassIcon,    "Sub-assembly"));
            GUILayout.EndVertical();
        }

        private void DrawRightArea() {
            var persBox         = new GUIStyle(HighLogic.Skin.box)      { padding   = new RectOffset(5, 5, 10, 10)  };
            var persBoxTitle    = new GUIStyle(HighLogic.Skin.box)      { padding   = new RectOffset(5, 5, 15, 15)  };
            var centerBtn       = new GUIStyle(HighLogic.Skin.button)   { alignment = TextAnchor.MiddleCenter       };

            var width = _secondRectWidth - 35;

            GUILayout.BeginVertical(GUILayout.Width(width));
            GUILayout.Label("DC - Mendacium (Launcher)".Color(Yellow).Size(25).Bold(), persBoxTitle);

                DrawSlideShow();
                GUILayout.Space(3);
                GUILayout.BeginHorizontal(GUIStyle.none);
                GUILayout.BeginVertical(HighLogic.Skin.box, GUILayout.Width(width / 2), GUILayout.Height(250));
                    GUILayout.Space(2);
                    GUILayout.Label("Auteur :".Color(Green).Size(17).Bold() + " Dakitess".Color("silver").Size(17).Bold());
                    GUILayout.Label("<b><size=17><color="+Green+">Téléchargement : </color><color=silver>19</color></size></b>");
                    GUILayout.Label("<b><size=17><color=" + Green + ">Note : </color><color=silver>4,5</color></size></b>");
                    GUILayout.Label("<b><size=17><color=" + Green + ">Equipage : </color><color=silver>2</color></size></b>");
                    GUILayout.Label("<b><size=17><color=" + Green + ">Nombre de parts : </color><color=silver>84</color></size></b>");
                    GUILayout.Label("<b><size=17><color=" + Green + ">Equipage : </color><color=silver>2</color></size></b>");
                    GUILayout.Label("<b><size=17><color=" + Green + ">Mods : </color><color=silver>Kethane, KW Rocketry</color></size></b>");

                GUILayout.EndVertical();
                GUILayout.Space(2);

                GUILayout.BeginVertical(HighLogic.Skin.box, GUILayout.Height(250));
                GUILayout.Label("<b><size=17><color=" + Green + ">Description : \n</color><color=silver>Un lanceur aussi esthétique qu'efficace, peut être le meilleur représentant du savoir faire de la Dakitess Corporation</color></size></b>");

                GUILayout.EndVertical();
            GUILayout.EndHorizontal();
                GUILayout.BeginVertical(GUIStyle.none);
                GUILayout.Button("Téléchargement", centerBtn);
                GUILayout.EndVertical();

            GUILayout.EndVertical();
             
        }

        private void DrawSlideShow() {
            var preIndex = _currentImage <= 0 ? _imageArray.Count - 1 : _currentImage - 1;
            var nextIndex = _currentImage >= _imageArray.Count - 1 ? 0 : _currentImage + 1;

            GUILayout.BeginHorizontal(HighLogic.Skin.box);

            if (GUILayout.Button(_imageArray[preIndex], HighLogic.Skin.button, GUILayout.Width(_imageArray[preIndex].width / 1.6f))) {
                _currentImage--;
                if (_currentImage < 0)
                    _currentImage = _imageArray.Count - 1;
            }

            GUILayout.Label(_imageArray[_currentImage], HighLogic.Skin.button);

            if (GUILayout.Button(_imageArray[nextIndex], HighLogic.Skin.button, GUILayout.Width(_imageArray[nextIndex].width / 1.6f))) {
                _currentImage++;
                if (_currentImage >= _imageArray.Count)
                    _currentImage = 0;
            }
            GUILayout.EndHorizontal();
        }

        private static string GetPrez(string name, string auteur, string rated, string nbDownload) {
            name        = "\n"+name.Color(Yellow).ReturnLine();
            auteur = (" Auteur : ".Color(Green) + auteur).ReturnLine();
            rated = (" Note : ".Color(Green) + rated).ReturnLine();
            nbDownload = (" Téléchargements : ".Color(Green) + nbDownload).ReturnLine();
            return (name + auteur + rated + nbDownload).Size(13);
        }

        private static float GetOffSet(float nbOffSetInside, float nbOffsetOutside) {
            return nbOffsetOutside * OffsetOutside + nbOffSetInside * OffsetInside;
        }
    } 
}
