using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;
namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Absol
{
    public class Absol_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Absol_LL0 = false;
        protected bool Absol_LL1 = false;
        protected bool Absol_LL2 = false;
        protected bool Absol_LL3 = false;
        protected bool Absol_LL4 = false;
        protected bool Absol_LL5 = false;
        protected bool Absol_LL6 = false;
        protected bool Absol_LL7 = false;

        public void Absol_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Absol_LL1,
                Absol_LL2, 
                Absol_LL3, 
                Absol_LL4, 
                Absol_LL5, 
                Absol_LL6,
                Absol_LL7
            };

            if (Absol_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Absol_LL0 = true;
            }

            if (Absol_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Absol_LL1 = true;
            }

            if (Absol_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Absol_LL2 = true;
            }

            if (Absol_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Absol_LL3 = true;
            }

            if (Absol_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Absol_LL4 = true;
            }

            if (Absol_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Absol_LL5 = true;
            }

            if (Absol_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Absol_LL6 = true;
            }

            if (Absol_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Absol_LL7 = true;
            }
        }
    }
}