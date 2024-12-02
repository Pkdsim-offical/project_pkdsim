using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Leafeon
{
    public class Leafeon_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Leafeon_LL0 = false;
        protected bool Leafeon_LL1 = false;
        protected bool Leafeon_LL2 = false;
        protected bool Leafeon_LL3 = false;
        protected bool Leafeon_LL4 = false;
        protected bool Leafeon_LL5 = false;
        protected bool Leafeon_LL6 = false;
        protected bool Leafeon_LL7 = false;

        public void Leafeon_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Leafeon_LL1,
                Leafeon_LL2,
                Leafeon_LL3,
                Leafeon_LL4,
                Leafeon_LL5,
                Leafeon_LL6,
                Leafeon_LL7
            };

            if (Leafeon_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Leafeon_LL0 = true;
            }

            if (Leafeon_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Leafeon_LL1 = true;
            }

            if (Leafeon_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Leafeon_LL2 = true;
            }

            if (Leafeon_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Leafeon_LL3 = true;
            }

            if (Leafeon_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Leafeon_LL4 = true;
            }

            if (Leafeon_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Leafeon_LL5 = true;
            }

            if (Leafeon_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Leafeon_LL6 = true;
            }

            if (Leafeon_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Leafeon_LL7 = true;
            }
        }
    }
}