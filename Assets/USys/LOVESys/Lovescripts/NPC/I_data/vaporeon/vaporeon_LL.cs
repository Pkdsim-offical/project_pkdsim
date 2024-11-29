using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Vaporeon_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Vaporeon_LL0 = false;
    protected bool Vaporeon_LL1 = false;
    protected bool Vaporeon_LL2 = false;
    protected bool Vaporeon_LL3 = false;
    protected bool Vaporeon_LL4 = false;
    protected bool Vaporeon_LL5 = false;
    protected bool Vaporeon_LL6 = false;
    protected bool Vaporeon_LL7 = false;

    public void Vaporeon_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Vaporeon_LL1,
            Vaporeon_LL2,
            Vaporeon_LL3,
            Vaporeon_LL4,
            Vaporeon_LL5,
            Vaporeon_LL6,
            Vaporeon_LL7
        };

        if (Vaporeon_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Vaporeon_LL0 = true;
        }

        if (Vaporeon_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Vaporeon_LL1 = true;
        }

        if (Vaporeon_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Vaporeon_LL2 = true;
        }

        if (Vaporeon_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Vaporeon_LL3 = true;
        }

        if (Vaporeon_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Vaporeon_LL4 = true;
        }

        if (Vaporeon_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Vaporeon_LL5 = true;
        }

        if (Vaporeon_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Vaporeon_LL6 = true;
        }

        if (Vaporeon_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Vaporeon_LL7 = true;
        }
    }
}