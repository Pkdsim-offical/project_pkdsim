using project_pkdsim.USys.AUSys.Modules.AUDIOSys;
namespace project_pkdsim.USys.AUSys.Modules
{
    public class AUSysI
    {
        AudioSys AudioSys;
        public void LoadAudioSys()
        {
            AudioSys.AudioSysI();
        }
        public void AUSys_I()
        {
            LoadAudioSys();
        }
    }
}