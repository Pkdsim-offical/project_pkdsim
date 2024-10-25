using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Dragapult_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Dragapult_LL1 = false;
    protected bool Dragapult_LL2 = false;
    protected bool Dragapult_LL3 = false;
    protected bool Dragapult_LL4 = false;
    protected bool Dragapult_LL5 = false;
    protected bool Dragapult_LL6 = false;

    public void Dragapult_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Dragapult_LL1,
            Dragapult_LL2,
            Dragapult_LL3,
            Dragapult_LL4,
            Dragapult_LL5,
            Dragapult_LL6
        };

        if (Dragapult_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Dragapult_LL1 = true;
        }
        if (Dragapult_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Dragapult_LL2 = true;
        }
        if (Dragapult_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Dragapult_LL3 = true;
        }
        if (Dragapult_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Dragapult_LL4 = true;
        }
        if (Dragapult_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Dragapult_LL5 = true;
        }
        if (Dragapult_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Dragapult_LL6 = true;
        }
    }
}