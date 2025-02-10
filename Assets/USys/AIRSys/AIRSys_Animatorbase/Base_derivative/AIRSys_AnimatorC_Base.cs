
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative
{


    public class AIRSys_AnimatorC_Base : MonoBehaviour
    {
        protected Animator animator;
        protected NavMeshAgent agent;

        protected virtual void Start()
        {
            animator = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>();
        }

        protected void SetIdle()
        {
            animator.Play("Idle");
        }

        protected void SetWalking()
        {
            animator.Play("Walk");
        }

        protected void SetRunning()
        {
            animator.Play("Run");
        }
    }
}
