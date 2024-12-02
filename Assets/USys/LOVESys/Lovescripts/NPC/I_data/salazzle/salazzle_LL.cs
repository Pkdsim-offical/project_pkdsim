using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Salazzle
{
    public class Salazzle_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Salazzle_LL0 = false;
        protected bool Salazzle_LL1 = false;
        protected bool Salazzle_LL2 = false;
        protected bool Salazzle_LL3 = false;
        protected bool Salazzle_LL4 = false;
        protected bool Salazzle_LL5 = false;
        protected bool Salazzle_LL6 = false;
        protected bool Salazzle_LL7 = false;

        public void Salazzle_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Salazzle_LL1,
                Salazzle_LL2,
                Salazzle_LL3,
                Salazzle_LL4,
                Salazzle_LL5,
                Salazzle_LL6,
                Salazzle_LL7
            };

            if (Salazzle_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Salazzle_LL0 = true;
            }

            if (Salazzle_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Salazzle_LL1 = true;
            }

            if (Salazzle_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Salazzle_LL2 = true;
            }

            if (Salazzle_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Salazzle_LL3 = true;
            }

            if (Salazzle_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Salazzle_LL4 = true;
            }

            if (Salazzle_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Salazzle_LL5 = true;
            }

            if (Salazzle_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Salazzle_LL6 = true;
            }

            if (Salazzle_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Salazzle_LL7 = true;
            }
        }
    }
}