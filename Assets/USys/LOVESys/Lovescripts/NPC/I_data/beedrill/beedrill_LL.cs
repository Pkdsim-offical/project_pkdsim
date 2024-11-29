using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;

public class Beedrill_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Beedrill_LL0 = false;
    protected bool Beedrill_LL1 = false;
    protected bool Beedrill_LL2 = false;
    protected bool Beedrill_LL3 = false;
    protected bool Beedrill_LL4 = false;
    protected bool Beedrill_LL5 = false;
    protected bool Beedrill_LL6 = false;
    protected bool Beedrill_LL7 = false;

    public void Beedrill_LLI()
    {
        LoveLevel = new List<bool>()
        {
            Beedrill_LL0,
            Beedrill_LL1,
            Beedrill_LL2,
            Beedrill_LL3,
            Beedrill_LL4,
            Beedrill_LL5,
            Beedrill_LL6,
            Beedrill_LL7
        };

        if (Beedrill_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Beedrill_LL0 = true;
        }

        if (Beedrill_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Beedrill_LL1 = true;
        }

        if (Beedrill_LL1 == base.LoveLevel_ProgressStates[2])
        {
            Beedrill_LL2 = true;
        }

        if (Beedrill_LL2 == base.LoveLevel_ProgressStates[3])
        {
            Beedrill_LL2 = true;
        }

        if (Beedrill_LL3 == base.LoveLevel_ProgressStates[4])
        {
            Beedrill_LL3 = true;
        }

        if (Beedrill_LL4 == base.LoveLevel_ProgressStates[5])
        {
            Beedrill_LL4 = true;
        }

        if (Beedrill_LL5 == base.LoveLevel_ProgressStates[6])
        {
            Beedrill_LL5 = true;
        }

        if (Beedrill_LL6 == base.LoveLevel_ProgressStates[7])
        {
            Beedrill_LL6 = true;
        }
    }
}