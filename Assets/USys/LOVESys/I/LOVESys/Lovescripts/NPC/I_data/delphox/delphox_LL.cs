using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Delphox
{
    public class Delphox_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Delphox_LL0 = false;
        protected bool Delphox_LL1 = false;
        protected bool Delphox_LL2 = false;
        protected bool Delphox_LL3 = false;
        protected bool Delphox_LL4 = false;
        protected bool Delphox_LL5 = false;
        protected bool Delphox_LL6 = false;
        protected bool Delphox_LL7 = false;

        public void Delphox_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Delphox_LL1,
                Delphox_LL2, 
                Delphox_LL3, 
                Delphox_LL4, 
                Delphox_LL5, 
                Delphox_LL6,
                Delphox_LL7
            };

            if (Delphox_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Delphox_LL0 = true;
            }

            if (Delphox_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Delphox_LL1 = true;
            }

            if (Delphox_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Delphox_LL2 = true;
            }

            if (Delphox_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Delphox_LL3 = true;
            }

            if (Delphox_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Delphox_LL4 = true;
            }

            if (Delphox_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Delphox_LL5 = true;
            }

            if (Delphox_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Delphox_LL6 = true;
            }

            if (Delphox_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Delphox_LL7 = true;
            }
        }
    }
}