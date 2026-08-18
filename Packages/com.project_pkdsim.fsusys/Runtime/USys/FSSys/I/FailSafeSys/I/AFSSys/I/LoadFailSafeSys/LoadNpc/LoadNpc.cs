using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.NPC.NPC_LFS_AnimatorBase;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.Load.Npc
{
    public class LoadNpc
    {
        private NPC_LFSAnimatorLoader NPC_LFSAnimatorLoader;
        public void LoadNpcAFS()
        {
            NPC_LFSAnimatorLoader.NPC_LoadFailSafeSAnimator();
        }
    }
}