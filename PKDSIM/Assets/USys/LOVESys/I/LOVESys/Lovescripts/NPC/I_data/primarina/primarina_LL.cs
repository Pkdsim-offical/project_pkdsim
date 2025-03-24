using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Primarina
{
    public class Primarina_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Primarina_LL0 = false;
        protected bool Primarina_LL1 = false;
        protected bool Primarina_LL2 = false;
        protected bool Primarina_LL3 = false;
        protected bool Primarina_LL4 = false;
        protected bool Primarina_LL5 = false;
        protected bool Primarina_LL6 = false;
        protected bool Primarina_LL7 = false;

        public void Primarina_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Primarina_LL1,
                Primarina_LL2,
                Primarina_LL3,
                Primarina_LL4,
                Primarina_LL5,
                Primarina_LL6,
                Primarina_LL7
            };

            if (Primarina_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Primarina_LL0 = true;
            }

            if (Primarina_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Primarina_LL1 = true;
            }

            if (Primarina_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Primarina_LL2 = true;
            }

            if (Primarina_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Primarina_LL3 = true;
            }

            if (Primarina_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Primarina_LL4 = true;
            }

            if (Primarina_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Primarina_LL5 = true;
            }

            if (Primarina_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Primarina_LL6 = true;
            }

            if (Primarina_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Primarina_LL7 = true;
            }
        }
    }
}