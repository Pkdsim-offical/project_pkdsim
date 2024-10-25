using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Primarina_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Primarina_LL1 = false;
    protected bool Primarina_LL2 = false;
    protected bool Primarina_LL3 = false;
    protected bool Primarina_LL4 = false;
    protected bool Primarina_LL5 = false;
    protected bool Primarina_LL6 = false;

    public void Primarina_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Primarina_LL1,
            Primarina_LL2,
            Primarina_LL3,
            Primarina_LL4,
            Primarina_LL5,
            Primarina_LL6
        };

        if (Primarina_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Primarina_LL1 = true;
        }
        if (Primarina_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Primarina_LL2 = true;
        }
        if (Primarina_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Primarina_LL3 = true;
        }
        if (Primarina_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Primarina_LL4 = true;
        }
        if (Primarina_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Primarina_LL5 = true;
        }
        if (Primarina_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Primarina_LL6 = true;
        }
    }
}