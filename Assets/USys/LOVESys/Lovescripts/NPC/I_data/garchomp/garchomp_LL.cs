using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Garchomp
{
    public class Garchomp_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Garchomp_LL0 = false;
        protected bool Garchomp_LL1 = false;
        protected bool Garchomp_LL2 = false;
        protected bool Garchomp_LL3 = false;
        protected bool Garchomp_LL4 = false;
        protected bool Garchomp_LL5 = false;
        protected bool Garchomp_LL6 = false;
        protected bool Garchomp_LL7 = false;

        public void Garchomp_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Garchomp_LL1,
                Garchomp_LL2,
                Garchomp_LL3,
                Garchomp_LL4,
                Garchomp_LL5,
                Garchomp_LL6,
                Garchomp_LL7
            };

            if (Garchomp_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Garchomp_LL0 = true;
            }

            if (Garchomp_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Garchomp_LL1 = true;
            }

            if (Garchomp_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Garchomp_LL2 = true;
            }

            if (Garchomp_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Garchomp_LL3 = true;
            }

            if (Garchomp_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Garchomp_LL4 = true;
            }

            if (Garchomp_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Garchomp_LL5 = true;
            }

            if (Garchomp_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Garchomp_LL6 = true;
            }

            if (Garchomp_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Garchomp_LL7 = true;
            }
        }
    }
}