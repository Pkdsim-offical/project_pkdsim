using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.Animator_I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AnimatorFailSafeSys.NPC.NPC_LFS_AnimatorBase
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

        private LFS_NoivernFailSafe LFS_NoivernFailSafeAnimator;
        private LFS_AbsolFailSafe LFS_AbsolFailSafeAnimator;
        private LFS_BeedrillFailSafe LFS_BeedrillFailSafeAnimator;
        private LFS_BraixenFailSafe LFS_BraixenFailSafeAnimator;
        private LFS_CinderaceFailSafe LFS_CinderaceFailSafeAnimator;
        private LFS_DelphoxFailSafe LFS_DelphoxFailSafeAnimator;
        private LFS_DragapultFailSafe LFS_DragapultFailSafeAnimator;
        private LFS_FrostlassFailSafe LFS_FrostlassFailSafeAnimator;
        private LFS_GarchompFailSafe LFS_GarchompFailSafeAnimator;
        private LFS_HattereneFailSafe LFS_HattereneFailSafeAnimator;
        private LFS_LopunnyFailSafe LFS_LopunnyFailSafeAnimator;
        private LFS_LucarioFailSafe LFS_LucarioFailSafeAnimator;
        private LFS_LunalaFailSafe LFS_LunalaFailSafeAnimator;
        private LFS_MeowscaradaFailSafe LFS_MeowscaradaFailSafeAnimator;
        private LFS_PheromosaFailSafe LFS_PheromosaFailSafeAnimator;
        private LFS_PrimarinaFailSafe LFS_PrimarinaFailSafeAnimator;
        private LFS_ZoroarkFailSafe LFS_ZoroarkFailSafeAnimator;

        private void NPC_LoadFailSafeSAnimator()
        {
            // LFS_VaporeonFailSafeAnimator();
            // LFS_FlareonFailSafeAnimator();    
            // LFS_JolteonFailSafeAnimator();
            // LFS_EspeonFailSafeAnimator();
            // LFS_UmbreonFailSafeAnimator();
            // LFS_GlaceonFailSafeAnimator();
            // LFS_LeafeonFailSafeAnimator();
            // LFS_SylveonFailSafeAnimator();
            // LFS_NoivernFailSafeAnimator();
            // LFS_AbsolFailSafeAnimator();
            // LFS_BeedrillFailSafeAnimator();
            // LFS_BraixenFailSafeAnimator();
            // LFS_CinderaceFailSafeAnimator();
            // LFS_DelphoxFailSafeAnimator();
            // LFS_DragapultFailSafeAnimator();
            // LFS_FrostlassFailSafeAnimator();
            // LFS_GarchompFailSafeAnimator();
            // LFS_HattereneFailSafeAnimator();
            // LFS_LopunnyFailSafeAnimator();
            // LFS_LucarioFailSafeAnimator();
            // LFS_LunalaFailSafeAnimator();
            // LFS_MeowscaradaFailSafeAnimator();
            // LFS_PheromosaFailSafeAnimator();
            // LFS_PrimarinaFailSafeAnimator();
            // LFS_UmbreonFailSafeAnimator();
            // LFS_ZoroarkFailSafeAnimator();
        }
    }
}




// animator.SetBool("IsRunning", true); // Example: Set IsRunning bool parameter to true
// animator.SetTrigger("Jump");         // Example: Trigger for Jump animation
// animator.SetTrigger(IsWalking);      // Example: Trigger for Walk animation
// animator.SetTrigger(IsSitting);      // Example: Trigger for Sitting animation
// animator.SetTrigger(IsStanding);     // Example: Trigger for Standing animation
// animator.SetTrigger(IsIdle);         // Example: Trigger for Idle animation