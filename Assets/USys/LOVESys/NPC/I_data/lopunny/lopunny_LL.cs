using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Lopunny_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Lopunny_LL1 = false;
    protected bool Lopunny_LL2 = false;
    protected bool Lopunny_LL3 = false;
    protected bool Lopunny_LL4 = false;
    protected bool Lopunny_LL5 = false;
    protected bool Lopunny_LL6 = false;

    public void Lopunny_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Lopunny_LL1,
            Lopunny_LL2,
            Lopunny_LL3,
            Lopunny_LL4,
            Lopunny_LL5,
            Lopunny_LL6
        };

        if (Lopunny_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Lopunny_LL1 = true;
        }
        if (Lopunny_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Lopunny_LL2 = true;
        }
        if (Lopunny_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Lopunny_LL3 = true;
        }
        if (Lopunny_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Lopunny_LL4 = true;
        }
        if (Lopunny_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Lopunny_LL5 = true;
        }
        if (Lopunny_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Lopunny_LL6 = true;
        }
    }
}