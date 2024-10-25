using System.Collections.Generic;
using project_pkdsim.Assets.USys.LOVESys.BASE;


public class Sylveon_LL : LOVE_Asys
{
    protected List<bool> LoveLevel;
    protected bool Sylveon_LL1 = false;
    protected bool Sylveon_LL2 = false;
    protected bool Sylveon_LL3 = false;
    protected bool Sylveon_LL4 = false;
    protected bool Sylveon_LL5 = false;
    protected bool Sylveon_LL6 = false;

    public void Sylveon_LL0()
    {
        LoveLevel = new List<bool>()
        {
            Sylveon_LL1,
            Sylveon_LL2,
            Sylveon_LL3,
            Sylveon_LL4,
            Sylveon_LL5,
            Sylveon_LL6
        };

        if (Sylveon_LL1 == base.LoveLevel_ProgressStates[0])
        {
            Sylveon_LL1 = true;
        }
        if (Sylveon_LL2 == base.LoveLevel_ProgressStates[1])
        {
            Sylveon_LL2 = true;
        }
        if (Sylveon_LL3 == base.LoveLevel_ProgressStates[2])
        {
            Sylveon_LL3 = true;
        }
        if (Sylveon_LL4 == base.LoveLevel_ProgressStates[3])
        {
            Sylveon_LL4 = true;
        }
        if (Sylveon_LL5 == base.LoveLevel_ProgressStates[4])
        {
            Sylveon_LL5 = true;
        }
        if (Sylveon_LL6 == base.LoveLevel_ProgressStates[5])
        {
            Sylveon_LL6 = true;
        }
    }
}