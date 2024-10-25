using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Tsareena_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Tsareena_LL1 = false;
    protected bool Tsareena_LL2 = false;
    protected bool Tsareena_LL3 = false;
    protected bool Tsareena_LL4 = false;
    protected bool Tsareena_LL5 = false;
    protected bool Tsareena_LL6 = false;

    public void Tsareena_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Tsareena_LL1,
            Tsareena_LL2,
            Tsareena_LL3,
            Tsareena_LL4,
            Tsareena_LL5,
            Tsareena_LL6
        };

        if (Tsareena_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Tsareena_LL1 = true;
        }
        if (Tsareena_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Tsareena_LL2 = true;
        }
        if (Tsareena_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Tsareena_LL3 = true;
        }
        if (Tsareena_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Tsareena_LL4 = true;
        }
        if (Tsareena_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Tsareena_LL5 = true;
        }
        if (Tsareena_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Tsareena_LL6 = true;
        }
    }
}