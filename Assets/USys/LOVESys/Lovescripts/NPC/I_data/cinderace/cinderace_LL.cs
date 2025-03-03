using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Cinderace
{
    public class Cinderace_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Cinderace_LL0 = false;
        protected bool Cinderace_LL1 = false;
        protected bool Cinderace_LL2 = false;
        protected bool Cinderace_LL3 = false;
        protected bool Cinderace_LL4 = false;
        protected bool Cinderace_LL5 = false;
        protected bool Cinderace_LL6 = false;
        protected bool Cinderace_LL7 = false;

        public void Cinderace_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Cinderace_LL1,
                Cinderace_LL2, 
                Cinderace_LL3, 
                Cinderace_LL4, 
                Cinderace_LL5, 
                Cinderace_LL6,
                Cinderace_LL7
            };

            if (Cinderace_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Cinderace_LL0 = true;
            }

            if (Cinderace_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Cinderace_LL1 = true;
            }

            if (Cinderace_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Cinderace_LL2 = true;
            }

            if (Cinderace_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Cinderace_LL3 = true;
            }

            if (Cinderace_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Cinderace_LL4 = true;
            }

            if (Cinderace_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Cinderace_LL5 = true;
            }

            if (Cinderace_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Cinderace_LL6 = true;
            }

            if (Cinderace_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Cinderace_LL7 = true;
            }
        }
    }
}