using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Zoroark_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Zoroark_LL0 = false;
    protected bool Zoroark_LL1 = false;
    protected bool Zoroark_LL2 = false;
    protected bool Zoroark_LL3 = false;
    protected bool Zoroark_LL4 = false;
    protected bool Zoroark_LL5 = false;
    protected bool Zoroark_LL6 = false;
    protected bool Zoroark_LL7 = false;

    public void Zoroark_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Zoroark_LL1,
            Zoroark_LL2,
            Zoroark_LL3,
            Zoroark_LL4,
            Zoroark_LL5,
            Zoroark_LL6,
            Zoroark_LL7
        };

        if (Zoroark_LL0 == base.LoveLevel_ProgressStates[0])
        {
            Zoroark_LL0 = true;
        }

        if (Zoroark_LL1 == base.LoveLevel_ProgressStates[1])
        {
            Zoroark_LL1 = true;
        }

        if (Zoroark_LL2 == base.LoveLevel_ProgressStates[2])
        {
            Zoroark_LL2 = true;
        }

        if (Zoroark_LL3 == base.LoveLevel_ProgressStates[3])
        {
            Zoroark_LL3 = true;
        }

        if (Zoroark_LL4 == base.LoveLevel_ProgressStates[4])
        {
            Zoroark_LL4 = true;
        }

        if (Zoroark_LL5 == base.LoveLevel_ProgressStates[5])
        {
            Zoroark_LL5 = true;
        }

        if (Zoroark_LL6 == base.LoveLevel_ProgressStates[6])
        {
            Zoroark_LL6 = true;
        }

        if (Zoroark_LL7 == base.LoveLevel_ProgressStates[7])
        {
            Zoroark_LL7 = true;
        }
    }
}