
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_Animatorbase.Base_derivative;
using UnityEngine;
using UnityEngine.AI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAnimator.Fr_Animator
{
        public class Fr_Animator : AIRSys_AnimatorC_Base
        {
                private float speed;
                private NavMeshAgent Agent;
                protected override void Start()
                {
                        agent = GetComponent<NavMeshAgent>();
                }
                private void Update()
                {
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
                public void  Load_Fr_Animator()
                {
                        if(speed < 0.1f)
                        {
                                Debug.Log("Frostlass is walking");
                        }
                        else if(speed < 3.0f)
                        {
                                Debug.Log("Frostlass is running");
                        }
                        else
                        {
                                Debug.Log("Frostlass is idle");
                        }
                }
        }
}
