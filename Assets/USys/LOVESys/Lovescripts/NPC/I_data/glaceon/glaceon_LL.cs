using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Glaceon_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Glaceon_LL0 = false;
    protected bool Glaceon_LL1 = false;
    protected bool Glaceon_LL2 = false;
    protected bool Glaceon_LL3 = false;
    protected bool Glaceon_LL4 = false;
    protected bool Glaceon_LL5 = false;
    protected bool Glaceon_LL6 = false;
    protected bool Glaceon_LL7 = false;

    public void Glaceon_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Glaceon_LL1,
            Glaceon_LL2,
            Glaceon_LL3,
            Glaceon_LL4,
            Glaceon_LL5,
            Glaceon_LL6,
            Glaceon_LL7
        };

        if (Glaceon_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Glaceon_LL0 = true;
        }

        if (Glaceon_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Glaceon_LL1 = true;
        }

        if (Glaceon_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Glaceon_LL2 = true;
        }

        if (Glaceon_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Glaceon_LL3 = true;
        }

        if (Glaceon_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Glaceon_LL4 = true;
        }

        if (Glaceon_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Glaceon_LL5 = true;
        }

        if (Glaceon_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Glaceon_LL6 = true;
        }

        if (Glaceon_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Glaceon_LL7 = true;
        }
    }
}