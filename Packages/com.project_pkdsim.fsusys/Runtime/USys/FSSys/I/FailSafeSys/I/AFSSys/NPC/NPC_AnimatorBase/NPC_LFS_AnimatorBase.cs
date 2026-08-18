using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.Animator_I;
using project_pkdsim.Generics.NPC.Species.Type;

using UnityEngine;

using System.Collections.Generic;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.NPC.NPC_LFS_AnimatorBase
{
    public class NPC_LFSAnimatorLoader : MonoBehaviour
    {
        private LFS_GlaceonFailSafe GlaceonFailSafeAnimator;
        private LFS_LeafeonFailSafe LeafeonFailSafeAnimator;
        private LFS_JolteonFailSafe JolteonFailSafeAnimator;
        private LFS_EspeonFailSafe EspeonFailSafeAnimator;
        private LFS_SylveonFailSafe SylveonFailSafeAnimator;
        private LFS_VaporeonFailSafe VaporeonFailSafeAnimator;
        private LFS_UmbreonFailSafe UmbreonFailSafeAnimator;
        private LFS_FlareonFailSafe FlareonFailSafeAnimator;
        private LFS_NoivernFailSafe NoivernFailSafeAnimator;
        private LFS_AbsolFailSafe AbsolFailSafeAnimator;
        private LFS_BeedrillFailSafe BeedrillFailSafeAnimator;
        private LFS_BraixenFailSafe BraixenFailSafeAnimator;
        private LFS_CinderaceFailSafe CinderaceFailSafeAnimator;
        private LFS_DelphoxFailSafe DelphoxFailSafeAnimator;
        private LFS_DragapultFailSafe DragapultFailSafeAnimator;
        private LFS_FrostlassFailSafe FrostlassFailSafeAnimator;
        private LFS_GarchompFailSafe GarchompFailSafeAnimator;
        private LFS_HattereneFailSafe HattereneFailSafeAnimator;
        private LFS_LopunnyFailSafe LopunnyFailSafeAnimator;
        private LFS_LucarioFailSafe LucarioFailSafeAnimator;
        private LFS_LunalaFailSafe LunalaFailSafeAnimator;
        private LFS_MeowscaradaFailSafe MeowscaradaFailSafeAnimator;
        private LFS_PheromosaFailSafe PheromosaFailSafeAnimator;
        private LFS_PrimarinaFailSafe PrimarinaFailSafeAnimator;
        private LFS_ZoroarkFailSafe ZoroarkFailSafeAnimator;
        private LFS_GardevoirFailSafe GardevoirFailSafeAnimator;
        private LFS_BlazikenFailSafe BlazikenFailSafeAnimator;

        Dictionary<NPCSpeciesType, RuntimeAnimatorController> NPCFailSafeAnimators = new Dictionary<NPCSpeciesType, RuntimeAnimatorController>
        {
            
        };
        public void NPC_LoadFailSafeSAnimator()
        {
            VaporeonFailSafeAnimator.LoadFailSafeVaporeon_AnimatorController();
            FlareonFailSafeAnimator.LoadFailSafeFlareon_AnimatorController();    
            JolteonFailSafeAnimator.LoadFailSafeJolteon_AnimatorController();
            EspeonFailSafeAnimator.LoadFailSafeEspeon_AnimatorController();
            GlaceonFailSafeAnimator.LoadFailSafeGlaceon_AnimatorController();
            LeafeonFailSafeAnimator.LoadFailSafeLeafeon_AnimatorController();
            SylveonFailSafeAnimator.LoadFailSafeSylveon_AnimatorController();
            NoivernFailSafeAnimator.LoadFailSafeNoivern_AnimatorController();
            AbsolFailSafeAnimator.LoadFailSafeAbsol_AnimatorController();
            BeedrillFailSafeAnimator.LoadFailSafeBeedrill_AnimatorController();
            BraixenFailSafeAnimator.LoadFailSafeBraixen_AnimatorController();
            CinderaceFailSafeAnimator.LoadFailSafeCinderace_AnimatorController();
            DelphoxFailSafeAnimator.LoadFailSafeDelphox_AnimatorController();
            DragapultFailSafeAnimator.LoadFailSafeDragapult_AnimatorController();
            FrostlassFailSafeAnimator.LoadFailSafeFrostlass_AnimatorController();
            GarchompFailSafeAnimator.LoadFailSafeGarchomp_AnimatorController();
            HattereneFailSafeAnimator.LoadFailSafeHatterene_AnimatorController();
            LopunnyFailSafeAnimator.LoadFailSafeLopunny_AnimatorController();
            LucarioFailSafeAnimator.LoadFailSafeLucario_AnimatorController();
            LunalaFailSafeAnimator.LoadFailSafeLunala_AnimatorController();
            MeowscaradaFailSafeAnimator.LoadFailSafeMeowscarada_AnimatorController();
            PheromosaFailSafeAnimator.LoadFailSafePheromosa_AnimatorController();
            PrimarinaFailSafeAnimator.LoadFailSafePrimarina_AnimatorController();
            UmbreonFailSafeAnimator.LoadFailSafeUmbreon_AnimatorController();
            ZoroarkFailSafeAnimator.LoadFailSafeZoroark_AnimatorController();
            GardevoirFailSafeAnimator.LoadFailSafeGardevoir_AnimatorController();
            BlazikenFailSafeAnimator.LoadFailSafeBlaziken_AnimatorController();
        }
    }
}




// animator.SetBool("IsRunning", true); // Example: Set IsRunning bool parameter to true
// animator.SetTrigger("Jump");         // Example: Trigger for Jump animation
// animator.SetTrigger(IsWalking);      // Example: Trigger for Walk animation
// animator.SetTrigger(IsSitting);      // Example: Trigger for Sitting animation
// animator.SetTrigger(IsStanding);     // Example: Trigger for Standing animation
// animator.SetTrigger(IsIdle);         // Example: Trigger for Idle animation