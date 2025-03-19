using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Frostlass
{
    public class Frostlass_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Frostlass_LL0 = false;
        protected bool Frostlass_LL1 = false;
        protected bool Frostlass_LL2 = false;
        protected bool Frostlass_LL3 = false;
        protected bool Frostlass_LL4 = false;
        protected bool Frostlass_LL5 = false;
        protected bool Frostlass_LL6 = false;
        protected bool Frostlass_LL7 = false;

        public void Frostlass_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Frostlass_LL1,
                Frostlass_LL2,
                Frostlass_LL3,
                Frostlass_LL4,
                Frostlass_LL5,
                Frostlass_LL6,
                Frostlass_LL7
            };

            if (Frostlass_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Frostlass_LL0 = true;
            }

            if (Frostlass_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Frostlass_LL1 = true;
            }

            if (Frostlass_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Frostlass_LL2 = true;
            }

            if (Frostlass_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Frostlass_LL3 = true;
            }

            if (Frostlass_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Frostlass_LL4 = true;
            }

            if (Frostlass_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Frostlass_LL5 = true;
            }

            if (Frostlass_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Frostlass_LL6 = true;
            }

            if (Frostlass_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Frostlass_LL7 = true;
            }
        }
    }
}