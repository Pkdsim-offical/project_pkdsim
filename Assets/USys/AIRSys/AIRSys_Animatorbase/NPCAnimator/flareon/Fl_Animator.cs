
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative;
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAnimator.Fl_Animator
{
    public class Fl_NAV_Animator : AIRSys_AnimatorC_Base
    {
        private float speed;
        private NavMeshAgent Agent;
        protected override void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }
        private void Update()
            {
                float speed = agent.velocity.magnitude;
                if (speed < 0.1f)
                {
                    SetIdle();
                }
                else if (speed < 3.0f)
                {
                    SetWalking();
                }
                else
                {
                    SetRunning();
                }
            }
            public void  Load_Fl_Animator()
            {
                if(speed < 0.1f)
                {
                    Debug.Log("Flareon is walking");
                }
                else if(speed < 3.0f)
                {
                    Debug.Log("Flareon is running");
                }
                else
                {
                    Debug.Log("Flareon is idle");
                }
            }
    }
}