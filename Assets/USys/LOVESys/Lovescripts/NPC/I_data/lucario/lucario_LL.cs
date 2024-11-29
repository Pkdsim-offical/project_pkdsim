using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Lucario_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Lucario_LL0 = false;
    protected bool Lucario_LL1 = false;
    protected bool Lucario_LL2 = false;
    protected bool Lucario_LL3 = false;
    protected bool Lucario_LL4 = false;
    protected bool Lucario_LL5 = false;
    protected bool Lucario_LL6 = false;
    protected bool Lucario_LL7 = false;

    public void Lucario_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Lucario_LL1,
            Lucario_LL2,
            Lucario_LL3,
            Lucario_LL4,
            Lucario_LL5,
            Lucario_LL6,
            Lucario_LL7
        };

        if (Lucario_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Lucario_LL0 = true;
        }

        if (Lucario_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Lucario_LL1 = true;
        }

        if (Lucario_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Lucario_LL2 = true;
        }

        if (Lucario_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Lucario_LL3 = true;
        }

        if (Lucario_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Lucario_LL4 = true;
        }

        if (Lucario_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Lucario_LL5 = true;
        }

        if (Lucario_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Lucario_LL6 = true;
        }

        if (Lucario_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Lucario_LL7 = true;
        }
    }
}