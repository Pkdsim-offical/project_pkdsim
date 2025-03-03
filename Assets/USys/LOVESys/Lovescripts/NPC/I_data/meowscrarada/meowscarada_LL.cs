    using System.Collections.Generic;
    using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Meowscarada
{
    public class Meowscarada_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Meowscarada_LL0 = false;
        protected bool Meowscarada_LL1 = false;
        protected bool Meowscarada_LL2 = false;
        protected bool Meowscarada_LL3 = false;
        protected bool Meowscarada_LL4 = false;
        protected bool Meowscarada_LL5 = false;
        protected bool Meowscarada_LL6 = false;
        protected bool Meowscarada_LL7 = false;

        public void Meowscarada_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Meowscarada_LL1,
                Meowscarada_LL2,
                Meowscarada_LL3,
                Meowscarada_LL4,
                Meowscarada_LL5,
                Meowscarada_LL6,
                Meowscarada_LL7
            };

            if (Meowscarada_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Meowscarada_LL0 = true;
            }

            if (Meowscarada_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Meowscarada_LL1 = true;
            }

            if (Meowscarada_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Meowscarada_LL2 = true;
            }

            if (Meowscarada_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Meowscarada_LL3 = true;
            }

            if (Meowscarada_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Meowscarada_LL4 = true;
            }

            if (Meowscarada_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Meowscarada_LL5 = true;
            }

            if (Meowscarada_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Meowscarada_LL6 = true;
            }

            if (Meowscarada_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Meowscarada_LL7 = true;
            }
        }
    }
}