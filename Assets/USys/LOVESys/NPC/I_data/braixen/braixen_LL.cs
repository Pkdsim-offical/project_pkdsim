using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Braixen_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Braixen_LL1 = false;
    protected bool Braixen_LL2 = false;
    protected bool Braixen_LL3 = false;
    protected bool Braixen_LL4 = false;
    protected bool Braixen_LL5 = false;
    protected bool Braixen_LL6 = false;

    public void Braixen_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Braixen_LL1,
            Braixen_LL2,
            Braixen_LL3,
            Braixen_LL4,
            Braixen_LL5,
            Braixen_LL6
        };

        if (Braixen_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Braixen_LL1 = true;
        }
        if (Braixen_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Braixen_LL2 = true;
        }
        if (Braixen_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Braixen_LL3 = true;
        }
        if (Braixen_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Braixen_LL4 = true;
        }
        if (Braixen_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Braixen_LL5 = true;
        }
        if (Braixen_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Braixen_LL6 = true;
        }
    }
}   