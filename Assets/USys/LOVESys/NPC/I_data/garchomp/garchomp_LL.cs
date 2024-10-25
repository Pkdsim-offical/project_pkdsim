using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Garchomp_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Garchomp_LL1 = false;
    protected bool Garchomp_LL2 = false;
    protected bool Garchomp_LL3 = false;
    protected bool Garchomp_LL4 = false;
    protected bool Garchomp_LL5 = false;
    protected bool Garchomp_LL6 = false;

    public void Garchomp_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Garchomp_LL1,
            Garchomp_LL2,
            Garchomp_LL3,
            Garchomp_LL4,
            Garchomp_LL5,
            Garchomp_LL6
        };

        if (Garchomp_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Garchomp_LL1 = true;
        }
        if (Garchomp_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Garchomp_LL2 = true;
        }
        if (Garchomp_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Garchomp_LL3 = true;
        }
        if (Garchomp_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Garchomp_LL4 = true;
        }
        if (Garchomp_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Garchomp_LL5 = true;
        }
        if (Garchomp_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Garchomp_LL6 = true;
        }
    }
}