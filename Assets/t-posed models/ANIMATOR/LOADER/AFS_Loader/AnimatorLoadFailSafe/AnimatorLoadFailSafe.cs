using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.Animator_I;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.Animator_I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.AFS_Loader.AnimatorLoadFailSafe
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
            NoivernFailSafeAnimator();
            AbsolFailSafeAnimator();
            BeedrillFailSafeAnimator();
            BraixenFailSafeAnimator();
            CinderaceFailSafeAnimator();
            DelphoxFailSafeAnimator();
            DragapultFailSafeAnimator();
            FrostlassFailSafeAnimator();
            GarchompFailSafeAnimator();
            HattereneFailSafeAnimator();
            LopunnyFailSafeAnimator();
            LucarioFailSafeAnimator();
            LunalaFailSafeAnimator();
            MeowscaradaFailSafeAnimator();
            PheromosaFailSafeAnimator();
            PrimarinaFailSafeAnimator();
            ZoroarkFailSafeAnimator();
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
        private void NoivernFailSafeAnimator()
        {
            LFS_NoivernFailSafeAnimator.LoadFailSafeNoivern_AnimatorController();
        }
        private void AbsolFailSafeAnimator()
        {
            LFS_AbsolFailSafeAnimator.LoadFailSafeAbsol_AnimatorController();
        }
        private void BeedrillFailSafeAnimator()
        {
            LFS_BeedrillFailSafeAnimator.LoadFailSafeBeedrill_AnimatorController();
        }
        private void BraixenFailSafeAnimator()
        {
            LFS_BraixenFailSafeAnimator.LoadFailSafeBraixen_AnimatorController();
        }
        private void CinderaceFailSafeAnimator()
        {
            LFS_CinderaceFailSafeAnimator.LoadFailSafeCinderace_AnimatorController();
        }
        private void DelphoxFailSafeAnimator()
        {
            LFS_DelphoxFailSafeAnimator.LoadFailSafeDelphox_AnimatorController();
        }
        private void DragapultFailSafeAnimator()
        {
            LFS_DragapultFailSafeAnimator.LoadFailSafeDragapult_AnimatorController();
        }
        private void FrostlassFailSafeAnimator()
        {
            LFS_FrostlassFailSafeAnimator.LoadFailSafeFrostlass_AnimatorController();
        }
        private void GarchompFailSafeAnimator()
        {
            LFS_GarchompFailSafeAnimator.LoadFailSafeGarchomp_AnimatorController();
        }
        private void HattereneFailSafeAnimator()
        {
            LFS_HattereneFailSafeAnimator.LoadFailSafeHatterene_AnimatorController();
        }
        private void LopunnyFailSafeAnimator()
        {
            LFS_LopunnyFailSafeAnimator.LoadFailSafeLopunny_AnimatorController();
        }
        private void LucarioFailSafeAnimator()
        {
            LFS_LucarioFailSafeAnimator.LoadFailSafeLucario_AnimatorController();
        }
        private void LunalaFailSafeAnimator()
        {
            LFS_LunalaFailSafeAnimator.LoadFailSafeLunala_AnimatorController();
        }
        private void MeowscaradaFailSafeAnimator()
        {
            LFS_MeowscaradaFailSafeAnimator.LoadFailSafeMeowscarada_AnimatorController();
        }
        private void PheromosaFailSafeAnimator()
        {
            LFS_PheromosaFailSafeAnimator.LoadFailSafePheromosa_AnimatorController();
        }
        private void PrimarinaFailSafeAnimator()
        {
            LFS_PrimarinaFailSafeAnimator.LoadFailSafePrimarina_AnimatorController();
        }
        private void ZoroarkFailSafeAnimator()
        {
            LFS_ZoroarkFailSafeAnimator.LoadFailSafeZoroark_AnimatorController();
        }
    }
}