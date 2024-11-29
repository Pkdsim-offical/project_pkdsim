
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative;
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAnimator.Me_Animator
{
        public class Me_Animator : AIRSys_AnimatorC_Base
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
                public void Load_Me_Animator()
                {
                        if(speed < 0.1f)
                        {
                                Debug.Log("Meowscarada is walking");
                        }
                        else if(speed < 3.0f)
                        {
                                Debug.Log("Meowscarada is running");
                        }
                        else
                        {
                                Debug.Log("Meowscarada is idle");
                        }
                }
        }
}