using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.Animator_I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.NPC.NPC_LFS_AnimatorBase
{
    public class NPC_LFSAnimatorLoader : MonoBehaviour
    {
        private LFS_GlaceonFailSafe LFS_GlaceonFailSafeAnimator;
        private LFS_LeafeonFailSafe LFS_LeafeonFailSafeAnimator;
        private LFS_JolteonFailSafe LFS_JolteonFailSafeAnimator;
        private LFS_EspeonFailSafe LFS_EspeonFailSafeAnimator;
        private LFS_SylveonFailSafe LFS_SylveonFailSafeAnimator;
        private LFS_VaporeonFailSafe LFS_VaporeonFailSafeAnimator;
        private LFS_UmbreonFailSafe LFS_UmbreonFailSafeAnimator;
        private LFS_FlareonFailSafe LFS_FlareonFailSafeAnimator;

        // private void NPC_LoadFailSafeSAnimator()
        // {

        //     LFS_VaporeonFailSafeAnimator();
        //     LFS_FlareonFailSafeAnimator();    
        //     LFS_JolteonFailSafeAnimator();
        //     LFS_EspeonFailSafeAnimator();
        //     LFS_UmbreonFailSafeAnimator();
        //     LFS_GlaceonFailSafeAnimator();
        //     LFS_LeafeonFailSafeAnimator();
        //     LFS_SylveonFailSafeAnimator();
        // }
    }
}




// animator.SetBool("IsRunning", true); // Example: Set IsRunning bool parameter to true
// animator.SetTrigger("Jump");         // Example: Trigger for Jump animation
// animator.SetTrigger(IsWalking);      // Example: Trigger for Walk animation
// animator.SetTrigger(IsSitting);      // Example: Trigger for Sitting animation
// animator.SetTrigger(IsStanding);     // Example: Trigger for Standing animation
// animator.SetTrigger(IsIdle);         // Example: Trigger for Idle animation