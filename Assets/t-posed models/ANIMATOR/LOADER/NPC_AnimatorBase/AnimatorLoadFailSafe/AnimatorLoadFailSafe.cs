using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.Animator_I;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.Animator_I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.NPC_AnimatorBase.AnimatorLoadFailSafe
{
    public class Animator_LoadFailSafe
    {
        private LFS_EspeonFailSafe LFS_EspeonFailSafeAnimator;
        private LFS_FlareonFailSafe LFS_FlareonFailSafeAnimator;
        private LFS_GlaceonFailSafe LFS_GlaceonFailSafeAnimator;
        private LFS_JolteonFailSafe LFS_JolteonFailSafeAnimator;
        private LFS_LeafeonFailSafe LFS_LeafeonFailSafeAnimator;
        private LFS_SylveonFailSafe LFS_SylveonFailSafeAnimator;
        private LFS_UmbreonFailSafe LFS_UmbreonFailSafeAnimator;
        private LFS_VaporeonFailSafe LFS_VaporeonFailSafeAnimator;

        public void FailSafe()
        {
            Debug.Log("Animator is Loading FailSafe");
            LoadFailSafe_AnimatorControllers();
        }
        private void LoadFailSafe_AnimatorControllers()
        {
            LeafeonFailSafeAnimator();
            GlaceonFailSafeAnimator();
            JolteonFailSafeAnimator();
            EspeonFailSafeAnimator();
            SylveonFailSafeAnimator();
            VaporeonFailSafeAnimator();
            UmbreonFailSafeAnimator();
            FlareonFailSafeAnimator();

        }
        private void LeafeonFailSafeAnimator()
        {
            LFS_LeafeonFailSafeAnimator.LoadFailSafeLeafeon_AnimatorController();
        }
        private void GlaceonFailSafeAnimator()
        {
            LFS_GlaceonFailSafeAnimator.LoadFailSafeGlaceon_AnimatorController();
        }
        private void JolteonFailSafeAnimator()
        {
            LFS_JolteonFailSafeAnimator.LoadFailSafeJolteon_AnimatorController();
        }
        private void EspeonFailSafeAnimator()
        {
            LFS_EspeonFailSafeAnimator.LoadFailSafeEspeon_AnimatorController();
        }
        private void SylveonFailSafeAnimator()
        {
            LFS_SylveonFailSafeAnimator.LoadFailSafeSylveon_AnimatorController();
        }
        private void VaporeonFailSafeAnimator()
        {
            LFS_VaporeonFailSafeAnimator.LoadFailSafeVaporeon_AnimatorController();
        }
        private void UmbreonFailSafeAnimator()
        {
            LFS_UmbreonFailSafeAnimator.LoadFailSafeUmbreon_AnimatorController();
        }
        private void FlareonFailSafeAnimator()
        {
            LFS_FlareonFailSafeAnimator.LoadFailSafeFlareon_AnimatorController();
        }
    }
}