using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Absol_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Absol_LL1 = false;
    protected bool Absol_LL2 = false;
    protected bool Absol_LL3 = false;
    protected bool Absol_LL4 = false;
    protected bool Absol_LL5 = false;
    protected bool Absol_LL6 = false;

    public void Absol_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Absol_LL1,
            Absol_LL2, 
            Absol_LL3, 
            Absol_LL4, 
            Absol_LL5, 
            Absol_LL6
        };

        if (Absol_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Absol_LL1 = true;
        }
        if (Absol_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Absol_LL2 = true;
        }
        if (Absol_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Absol_LL3 = true;
        }
        if (Absol_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Absol_LL4 = true;
        }
        if (Absol_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Absol_LL5 = true;
        }
        if (Absol_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Absol_LL6 = true;
        }
    }
}