using project_pkdsim.USys.MOSys.Modules.MONEYSys;

namespace project_pkdsim.USys.MOSys.Modules
{
    public class MOSysI 
    {
        MoneySys moneySys;

        public void MOSys_I() 
        {
            Get_MoneySys();
        }
        private void Get_MoneySys() 
        {
            moneySys.MoneySysI();
        }
    }
}