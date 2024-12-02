
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative;
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAnimator.Jo_Animator
{
        public class Jo_NAV_Animator: AIRSys_AnimatorC_Base
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
                public void Load_Jo_Animator()
                {
                        if(speed < 0.1f)
                        {
                                Debug.Log("Jolteon is walking");
                        }
                        else if(speed < 3.0f)
                        {
                                Debug.Log("Jolteon is running");
                        }
                        else
                        {
                                Debug.Log("Jolteon is idle");
                        }
                }
        }
}
