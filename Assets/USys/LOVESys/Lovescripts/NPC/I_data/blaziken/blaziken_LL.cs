using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;
namespace project_pkdsim.Assets.USys.LOVESys.LoveScripts.NPC.I_data.Blaziken
{
    public class Blaziken_LL : LOVE_Asys
    {
        protected List<bool> LoveLevel;
        protected bool Blaziken_LL0 = false;
        protected bool Blaziken_LL1 = false;
        protected bool Blaziken_LL2 = false;
        protected bool Blaziken_LL3 = false;
        protected bool Blaziken_LL4 = false;
        protected bool Blaziken_LL5 = false;
        protected bool Blaziken_LL6 = false;
        protected bool Blaziken_LL7 = false;

        public void Blaziken_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Blaziken_LL1,
                Blaziken_LL2,
                Blaziken_LL3,
                Blaziken_LL4,
                Blaziken_LL5,
                Blaziken_LL6,
                Blaziken_LL7
            };

            if (Blaziken_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Blaziken_LL0 = true;
            }

            if (Blaziken_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Blaziken_LL1 = true;
            }

            if (Blaziken_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Blaziken_LL2 = true;
            }

            if (Blaziken_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Blaziken_LL3 = true;
            }

            if (Blaziken_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Blaziken_LL4 = true;
            }

            if (Blaziken_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Blaziken_LL5 = true;
            }

            if (Blaziken_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Blaziken_LL6 = true;
            }

            if (Blaziken_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Blaziken_LL7 = true;
            }
        }
    }
}