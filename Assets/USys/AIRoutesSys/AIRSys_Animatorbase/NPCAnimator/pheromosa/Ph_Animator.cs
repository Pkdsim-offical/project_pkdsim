
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative;
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAnimator.Ph_Animator
{
        public class Ph_NAV_Animator : AIRSys_AnimatorC_Base
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
                public void Load_Ph_Animator()
                {
                        if(speed < 0.1f)
                        {
                                Debug.Log("Pheromosa is walking");
                        }
                        else if(speed < 3.0f)
                        {
                                Debug.Log("Pheromosa is running");
                        }
                        else
                        {
                                Debug.Log("Pheromosa is idle");
                        }
                }
        }
}