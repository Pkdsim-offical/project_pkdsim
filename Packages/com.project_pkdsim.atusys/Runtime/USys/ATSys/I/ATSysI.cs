using project_pkdsim.USys.ATSys.Modules.AnimatedTexturesSys;

namespace project_pkdsim.USys.ATSys.Modules
{
    public class ATSysI
    {
        private AnimatedTextureSys AnimatedTextureSys;

        public void ATSys_I()
        {
            GetAnimatedTextureSys();
        }
        
        public void GetAnimatedTextureSys()
        {
            AnimatedTextureSys.AnimatedTextureSysI();
        }
    }
}