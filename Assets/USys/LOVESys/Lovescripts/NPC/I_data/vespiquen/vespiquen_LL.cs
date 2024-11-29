using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Vespiquen_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Vespiquen_LL0 = false;
    protected bool Vespiquen_LL1 = false;
    protected bool Vespiquen_LL2 = false;
    protected bool Vespiquen_LL3 = false;
    protected bool Vespiquen_LL4 = false;
    protected bool Vespiquen_LL5 = false;
    protected bool Vespiquen_LL6 = false;
    protected bool Vespiquen_LL7 = false;

    public void Vespiquen_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Vespiquen_LL1,
            Vespiquen_LL2,
            Vespiquen_LL3,
            Vespiquen_LL4,
            Vespiquen_LL5,
            Vespiquen_LL6,
            Vespiquen_LL7
        };

        if (Vespiquen_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Vespiquen_LL0 = true;
        }

        if (Vespiquen_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Vespiquen_LL1 = true;
        }

        if (Vespiquen_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Vespiquen_LL2 = true;
        }

        if (Vespiquen_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Vespiquen_LL3 = true;
        }

        if (Vespiquen_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Vespiquen_LL4 = true;
        }

        if (Vespiquen_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Vespiquen_LL5 = true;
        }

        if (Vespiquen_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Vespiquen_LL6 = true;
        }

        if (Vespiquen_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Vespiquen_LL7 = true;
        }
    }
}