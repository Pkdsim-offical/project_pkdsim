using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Hatterene_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Hatterene_LL1 = false;
    protected bool Hatterene_LL2 = false;
    protected bool Hatterene_LL3 = false;
    protected bool Hatterene_LL4 = false;
    protected bool Hatterene_LL5 = false;
    protected bool Hatterene_LL6 = false;

    public void Hatterene_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Hatterene_LL1,
            Hatterene_LL2,
            Hatterene_LL3,
            Hatterene_LL4,
            Hatterene_LL5,
            Hatterene_LL6
        };

        if (Hatterene_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Hatterene_LL1 = true;
        }
        if (Hatterene_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Hatterene_LL2 = true;
        }
        if (Hatterene_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Hatterene_LL3 = true;
        }
        if (Hatterene_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Hatterene_LL4 = true;
        }
        if (Hatterene_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Hatterene_LL5 = true;
        }
        if (Hatterene_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Hatterene_LL6 = true;
        }
    }
}