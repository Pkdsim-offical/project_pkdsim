    using System.Collections.Generic;
    using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Umbreon
{
    public class Umbreon_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Umbreon_LL0 = false;
        protected bool Umbreon_LL1 = false;
        protected bool Umbreon_LL2 = false;
        protected bool Umbreon_LL3 = false;
        protected bool Umbreon_LL4 = false;
        protected bool Umbreon_LL5 = false;
        protected bool Umbreon_LL6 = false;
        protected bool Umbreon_LL7 = false;

        public void Umbreon_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Umbreon_LL1,
                Umbreon_LL2,
                Umbreon_LL3,
                Umbreon_LL4,
                Umbreon_LL5,
                Umbreon_LL6,
                Umbreon_LL7
            };

            if (Umbreon_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Umbreon_LL0 = true;
            }

            if (Umbreon_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Umbreon_LL1 = true;
            }

            if (Umbreon_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Umbreon_LL2 = true;
            }

            if (Umbreon_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Umbreon_LL3 = true;
            }

            if (Umbreon_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Umbreon_LL4 = true;
            }

            if (Umbreon_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Umbreon_LL5 = true;
            }

            if (Umbreon_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Umbreon_LL6 = true;
            }

            if (Umbreon_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Umbreon_LL7 = true;
            }
        }
    }
}