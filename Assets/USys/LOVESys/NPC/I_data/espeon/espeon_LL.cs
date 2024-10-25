using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Espeon_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Espeon_LL1 = false;
    protected bool Espeon_LL2 = false;
    protected bool Espeon_LL3 = false;
    protected bool Espeon_LL4 = false;
    protected bool Espeon_LL5 = false;
    protected bool Espeon_LL6 = false;

    public void Espeon_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Espeon_LL1,
            Espeon_LL2,
            Espeon_LL3,
            Espeon_LL4,
            Espeon_LL5,
            Espeon_LL6
        };

        if (Espeon_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Espeon_LL1 = true;
        }
        if (Espeon_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Espeon_LL2 = true;
        }
        if (Espeon_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Espeon_LL3 = true;
        }
        if (Espeon_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Espeon_LL4 = true;
        }
        if (Espeon_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Espeon_LL5 = true;
        }
        if (Espeon_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Espeon_LL6 = true;
        }
    }
}