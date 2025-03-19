using project_pkdsim.Assets.USys.LoveSys.I;

namespace project_pkdsim.Assets.USys.LoveSys
{
    public class LOVERSys : LOVESysI
    {
        protected void LoveSys()
        {
            Run();
        }
        public void LoveSysI()
        {
            LoveSys();
        }
    }
}