using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Jolteon_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Jolteon_LL0 = false;
    protected bool Jolteon_LL1 = false;
    protected bool Jolteon_LL2 = false;
    protected bool Jolteon_LL3 = false;
    protected bool Jolteon_LL4 = false;
    protected bool Jolteon_LL5 = false;
    protected bool Jolteon_LL6 = false;
    protected bool Jolteon_LL7 = false;

    public void Jolteon_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Jolteon_LL1,
            Jolteon_LL2,
            Jolteon_LL3,
            Jolteon_LL4,
            Jolteon_LL5,
            Jolteon_LL6,
            Jolteon_LL7
        };

        if (Jolteon_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Jolteon_LL0 = true;
        }

        if (Jolteon_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Jolteon_LL1 = true;
        }

        if (Jolteon_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Jolteon_LL2 = true;
        }

        if (Jolteon_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Jolteon_LL3 = true;
        }

        if (Jolteon_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Jolteon_LL4 = true;
        }

        if (Jolteon_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Jolteon_LL5 = true;
        }

        if (Jolteon_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Jolteon_LL6 = true;
        }

        if (Jolteon_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Jolteon_LL7 = true;
        }
    }
}