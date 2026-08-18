using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.AFS_Loader.AnimatorLoadFailSafe
{
    public class PARENTS_LFSAnimatorLoader
    {
        private LFS_EspeonParentsFailSafe LFS_EspeonFailSafeAnimator;
        private LFS_FlareonParentsFailSafe LFS_FlareonFailSafeAnimator;
        private LFS_GlaceonParentsFailSafe LFS_GlaceonFailSafeAnimator;
        private LFS_JolteonParentsFailSafe LFS_JolteonFailSafeAnimator;
        private LFS_LeafeonParentsFailSafe LFS_LeafeonFailSafeAnimator;
        private LFS_SylveonParentsFailSafe LFS_SylveonFailSafeAnimator;
        private LFS_UmbreonParentsFailSafe LFS_UmbreonFailSafeAnimator;
        private LFS_VaporeonParentsFailSafe LFS_VaporeonFailSafeAnimator;
        private LFS_NoivernParentsFailSafe LFS_NoivernFailSafeAnimator;
        private LFS_AbsolParentsFailSafe LFS_AbsolFailSafeAnimator;
        private LFS_BeedrillParentsFailSafe LFS_BeedrillFailSafeAnimator;
        private LFS_BraixenParentsFailSafe LFS_BraixenFailSafeAnimator;
        private LFS_CinderaceParentsFailSafe LFS_CinderaceFailSafeAnimator;
        private LFS_DelphoxParentsFailSafe LFS_DelphoxFailSafeAnimator;
        private LFS_DragapultParentsFailSafe LFS_DragapultFailSafeAnimator;
        private LFS_FrostlassParentsFailSafe LFS_FrostlassFailSafeAnimator;
        private LFS_GarchompParentsFailSafe LFS_GarchompFailSafeAnimator;
        private LFS_HattereneParentsFailSafe LFS_HattereneFailSafeAnimator;
        private LFS_LopunnyParentsFailSafe LFS_LopunnyFailSafeAnimator;
        private LFS_LucarioParentsFailSafe LFS_LucarioFailSafeAnimator;
        private LFS_LunalaParentsFailSafe LFS_LunalaFailSafeAnimator;
        private LFS_MeowscaradaParentsFailSafe LFS_MeowscaradaFailSafeAnimator;
        private LFS_PheromosaParentsFailSafe LFS_PheromosaFailSafeAnimator;
        private LFS_PrimarinaParentsFailSafe LFS_PrimarinaFailSafeAnimator;
        private LFS_ZoroarkParentsFailSafe LFS_ZoroarkFailSafeAnimator;

        public void FailSafe()
        {
            Debug.Log("Animator is Loading FailSafe");
            Parents_LoadFailSafeSAnimator();
        }
        public void Parents_LoadFailSafeSAnimator()
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
            LFS_LeafeonFailSafeAnimator.LoadFailSafeLeafeonParents_AnimatorController();
        }
        private void GlaceonFailSafeAnimator()
        {
            LFS_GlaceonFailSafeAnimator.LoadFailSafeGlaceonParents_AnimatorController();
        }
        private void JolteonFailSafeAnimator()
        {
            LFS_JolteonFailSafeAnimator.LoadFailSafeJolteonParents_AnimatorController();
        }
        private void EspeonFailSafeAnimator()
        {
            LFS_EspeonFailSafeAnimator.LoadFailSafeEspeonParents_AnimatorController();
        }
        private void SylveonFailSafeAnimator()
        {
            LFS_SylveonFailSafeAnimator.LoadFailSafeSylveonParents_AnimatorController();
        }
        private void VaporeonFailSafeAnimator()
        {
            LFS_VaporeonFailSafeAnimator.LoadFailSafeVaporeonParents_AnimatorController();
        }
        private void UmbreonFailSafeAnimator()
        {
            LFS_UmbreonFailSafeAnimator.LoadFailSafeUmbreonParents_AnimatorController();
        }
        private void FlareonFailSafeAnimator()
        {
            LFS_FlareonFailSafeAnimator.LoadFailSafeFlareonParents_AnimatorController();
        }
        private void NoivernFailSafeAnimator()
        {
            LFS_NoivernFailSafeAnimator.LoadFailSafeNoivernParents_AnimatorController();
        }
        private void AbsolFailSafeAnimator()
        {
            LFS_AbsolFailSafeAnimator.LoadFailSafeAbsolParents_AnimatorController();
        }
        private void BeedrillFailSafeAnimator()
        {
            LFS_BeedrillFailSafeAnimator.LoadFailSafeBeedrillParents_AnimatorController();
        }
        private void BraixenFailSafeAnimator()
        {
            LFS_BraixenFailSafeAnimator.LoadFailSafeBraixenParents_AnimatorController();
        }
        private void CinderaceFailSafeAnimator()
        {
            LFS_CinderaceFailSafeAnimator.LoadFailSafeCinderaceParents_AnimatorController();
        }
        private void DelphoxFailSafeAnimator()
        {
            LFS_DelphoxFailSafeAnimator.LoadFailSafeDelphoxParents_AnimatorController();
        }
        private void DragapultFailSafeAnimator()
        {
            LFS_DragapultFailSafeAnimator.LoadFailSafeDragapultParents_AnimatorController();
        }
        private void FrostlassFailSafeAnimator()
        {
            LFS_FrostlassFailSafeAnimator.LoadFailSafeFrostlassParents_AnimatorController();
        }
        private void GarchompFailSafeAnimator()
        {
            LFS_GarchompFailSafeAnimator.LoadFailSafeGarchompParents_AnimatorController();
        }
        private void HattereneFailSafeAnimator()
        {
            LFS_HattereneFailSafeAnimator.LoadFailSafeHattereneParents_AnimatorController();
        }
        private void LopunnyFailSafeAnimator()
        {
            LFS_LopunnyFailSafeAnimator.LoadFailSafeLopunnyParents_AnimatorController();
        }
        private void LucarioFailSafeAnimator()
        {
            LFS_LucarioFailSafeAnimator.LoadFailSafeLucarioParents_AnimatorController();
        }
        private void LunalaFailSafeAnimator()
        {
            LFS_LunalaFailSafeAnimator.LoadFailSafeLunalaParents_AnimatorController();
        }
        private void MeowscaradaFailSafeAnimator()
        {
            LFS_MeowscaradaFailSafeAnimator.LoadFailSafeMeowscaradaParents_AnimatorController();
        }
        private void PheromosaFailSafeAnimator()
        {
            LFS_PheromosaFailSafeAnimator.LoadFailSafePheromosaParents_AnimatorController();
        }
        private void PrimarinaFailSafeAnimator()
        {
            LFS_PrimarinaFailSafeAnimator.LoadFailSafePrimarinaParents_AnimatorController();
        }
        private void ZoroarkFailSafeAnimator()
        {
            LFS_ZoroarkFailSafeAnimator.LoadFailSafeZoroarkParents_AnimatorController();
        }
    }
}