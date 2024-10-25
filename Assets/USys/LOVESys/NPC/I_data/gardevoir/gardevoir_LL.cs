using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Gardevoir_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Gardevoir_LL1 = false;
    protected bool Gardevoir_LL2 = false;
    protected bool Gardevoir_LL3 = false;
    protected bool Gardevoir_LL4 = false;
    protected bool Gardevoir_LL5 = false;
    protected bool Gardevoir_LL6 = false;

    public void Gardevoir_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Gardevoir_LL1,
            Gardevoir_LL2,
            Gardevoir_LL3,
            Gardevoir_LL4,
            Gardevoir_LL5,
            Gardevoir_LL6
        };

        if (Gardevoir_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Gardevoir_LL1 = true;
        }
        if (Gardevoir_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Gardevoir_LL2 = true;
        }
        if (Gardevoir_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Gardevoir_LL3 = true;
        }
        if (Gardevoir_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Gardevoir_LL4 = true;
        }
        if (Gardevoir_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Gardevoir_LL5 = true;
        }
        if (Gardevoir_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Gardevoir_LL6 = true;
        }
    }
}