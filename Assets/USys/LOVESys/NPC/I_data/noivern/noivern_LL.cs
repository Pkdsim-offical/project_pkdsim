using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Noivern_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Noivern_LL1 = false;
    protected bool Noivern_LL2 = false;
    protected bool Noivern_LL3 = false;
    protected bool Noivern_LL4 = false;
    protected bool Noivern_LL5 = false;
    protected bool Noivern_LL6 = false;

    public void Noivern_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Noivern_LL1,
            Noivern_LL2,
            Noivern_LL3,
            Noivern_LL4,
            Noivern_LL5,
            Noivern_LL6
        };

        if (Noivern_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Noivern_LL1 = true;
        }
        if (Noivern_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Noivern_LL2 = true;
        }
        if (Noivern_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Noivern_LL3 = true;
        }
        if (Noivern_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Noivern_LL4 = true;
        }
        if (Noivern_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Noivern_LL5 = true;
        }
        if (Noivern_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Noivern_LL6 = true;
        }
    }
}