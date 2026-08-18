using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.AFS_Loader.AnimatorLoadFailSafe;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.Load.Parent
{
    public class LoadParent
    {
        private PARENTS_LFSAnimatorLoader Parents_LFSAnimatorLoader;
        public void LoadParentAFS()
        {
            Parents_LFSAnimatorLoader.Parents_LoadFailSafeSAnimator();
        }
    }
}