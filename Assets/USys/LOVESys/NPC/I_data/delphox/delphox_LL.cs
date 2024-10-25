using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Delphox_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Delphox_LL1 = false;
    protected bool Delphox_LL2 = false;
    protected bool Delphox_LL3 = false;
    protected bool Delphox_LL4 = false;
    protected bool Delphox_LL5 = false;
    protected bool Delphox_LL6 = false;

    public void Delphox_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Delphox_LL1,
            Delphox_LL2,
            Delphox_LL3,
            Delphox_LL4,
            Delphox_LL5,
            Delphox_LL6
        };

        if (Delphox_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Delphox_LL1 = true;
        }
        if (Delphox_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Delphox_LL2 = true;
        }
        if (Delphox_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Delphox_LL3 = true;
        }
        if (Delphox_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Delphox_LL4 = true;
        }
        if (Delphox_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Delphox_LL5 = true;
        }
        if (Delphox_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Delphox_LL6 = true;
        }
    }
}