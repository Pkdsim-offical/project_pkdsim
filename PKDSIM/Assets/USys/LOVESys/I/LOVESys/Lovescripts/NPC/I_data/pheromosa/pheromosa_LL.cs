using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Pheromosa
{
    public class Pheromosa_LL : LOVE_Asys_Base
    {
        protected List<bool> LoveLevel;
        protected bool Pheromosa_LL0 = false;
        protected bool Pheromosa_LL1 = false;
        protected bool Pheromosa_LL2 = false;
        protected bool Pheromosa_LL3 = false;
        protected bool Pheromosa_LL4 = false;
        protected bool Pheromosa_LL5 = false;
        protected bool Pheromosa_LL6 = false;
        protected bool Pheromosa_LL7 = false;

        public void Pheromosa_LLI()
        {
            LoveLevel = new List<bool>()
            {
                Pheromosa_LL1,
                Pheromosa_LL2,
                Pheromosa_LL3,
                Pheromosa_LL4,
                Pheromosa_LL5,
                Pheromosa_LL6,
                Pheromosa_LL7
            };

            if (Pheromosa_LL0 == base.LoveLevel_ProgressStates[0])
            {
                Pheromosa_LL0 = true;
            }

            if (Pheromosa_LL1 == base.LoveLevel_ProgressStates[1])
            {
                Pheromosa_LL1 = true;
            }

            if (Pheromosa_LL2 == base.LoveLevel_ProgressStates[2])
            {
                Pheromosa_LL2 = true;
            }

            if (Pheromosa_LL3 == base.LoveLevel_ProgressStates[3])
            {
                Pheromosa_LL3 = true;
            }

            if (Pheromosa_LL4 == base.LoveLevel_ProgressStates[4])
            {
                Pheromosa_LL4 = true;
            }

            if (Pheromosa_LL5 == base.LoveLevel_ProgressStates[5])
            {
                Pheromosa_LL5 = true;
            }

            if (Pheromosa_LL6 == base.LoveLevel_ProgressStates[6])
            {
                Pheromosa_LL6 = true;
            }

            if (Pheromosa_LL7 == base.LoveLevel_ProgressStates[7])
            {
                Pheromosa_LL7 = true;
            }
        }
    }
}