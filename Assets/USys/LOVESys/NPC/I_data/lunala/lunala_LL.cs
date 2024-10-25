using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Lunala_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Lunala_LL1 = false;
    protected bool Lunala_LL2 = false;
    protected bool Lunala_LL3 = false;
    protected bool Lunala_LL4 = false;
    protected bool Lunala_LL5 = false;
    protected bool Lunala_LL6 = false;

    public void Lunala_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Lunala_LL1,
            Lunala_LL2,
            Lunala_LL3,
            Lunala_LL4,
            Lunala_LL5,
            Lunala_LL6
        };

        if (Lunala_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Lunala_LL1 = true;
        }
        if (Lunala_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Lunala_LL2 = true;
        }
        if (Lunala_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Lunala_LL3 = true;
        }
        if (Lunala_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Lunala_LL4 = true;
        }
        if (Lunala_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Lunala_LL5 = true;
        }
        if (Lunala_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Lunala_LL6 = true;
        }
    }
}