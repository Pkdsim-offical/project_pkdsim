using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Flareon
{
    public class Flareon_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Flareon_LL0 = false;
        protected bool Flareon_LL1 = false;
        protected bool Flareon_LL2 = false;
        protected bool Flareon_LL3 = false;
        protected bool Flareon_LL4 = false;
        protected bool Flareon_LL5 = false;
        protected bool Flareon_LL6 = false;
        protected bool Flareon_LL7 = false;

        public void Flareon_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Flareon_LL1,
                Flareon_LL2,
                Flareon_LL3,
                Flareon_LL4,
                Flareon_LL5,
                Flareon_LL6,
                Flareon_LL7
            };

            if (Flareon_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Flareon_LL0 = true;
            }

            if (Flareon_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Flareon_LL1 = true;
            }

            if (Flareon_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Flareon_LL2 = true;
            }

            if (Flareon_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Flareon_LL3 = true;
            }

            if (Flareon_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Flareon_LL4 = true;
            }

            if (Flareon_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Flareon_LL5 = true;
            }

            if (Flareon_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Flareon_LL6 = true;
            }

            if (Flareon_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Flareon_LL7 = true;
            }
        }
    }
}