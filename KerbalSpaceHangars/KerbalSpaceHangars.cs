using KerbalSpaceHangars.UI;
using UnityEngine;

namespace KerbalSpaceHangars
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public partial class KerbalSpaceHangars : MonoBehaviour
    {

        private const ApplicationLauncher.AppScenes AppScenes = ApplicationLauncher.AppScenes.SPH | ApplicationLauncher.AppScenes.VAB;
        
        private ApplicationLauncherButton   _hangarButton;
        private KerbalSpaceHangarGui        _hangar;

        private bool _drawWindow;
        private bool _hidden;

        internal void Awake() {
            _hangar = new KerbalSpaceHangarGui();
            GameEvents.onGUIApplicationLauncherReady.Add(OnGuiAppLauncherReady);
        }

        internal void OnDestroy() {
            GameEvents.onGUIApplicationLauncherReady.Remove(OnGuiAppLauncherReady);
            if (_hangarButton != null) {
                ApplicationLauncher.Instance.RemoveModApplication(_hangarButton);
                ApplicationLauncher.Instance.RemoveApplication(_hangarButton);
                _hangarButton = null;
            }
        }

        internal void OnGuiAppLauncherReady() {
            if (!ApplicationLauncher.Ready) return;
            if (_hangarButton != null && ApplicationLauncher.Instance.Contains(_hangarButton, out _hidden)) return;

            _hangarButton = ApplicationLauncher.Instance.AddModApplication(
                () => _drawWindow = true,
                () => _drawWindow = false,
                () => ScreenMessages.PostScreenMessage("Ouvrir le hangar", 1, 0),
                null, null, null,
                AppScenes,
                GameDatabase.Instance.GetTexture("kriyss/KerbalSpaceHangars/Assets/home_w", false));
            ApplicationLauncher.Instance.EnableMutuallyExclusive(_hangarButton);
        }

        internal void OnGUI() {
            if (_drawWindow) {
                InputLockManager.SetControlLock(ControlTypes.All, "KerbalSpaceHangar");
                _hangar.Draw();
            } else {
                InputLockManager.RemoveControlLock("KerbalSpaceHangar");
            }
        }
    }
}
