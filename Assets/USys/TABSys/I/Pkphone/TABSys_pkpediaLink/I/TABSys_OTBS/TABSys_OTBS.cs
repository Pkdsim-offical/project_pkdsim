using project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.I.TSys_DPk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.I.TABSys_OTBS
{
        public class TABSys_OnTabSelected : MonoBehaviour
        {
                protected TABSys_DPk TSys_DPk;

                private int currentTabIndex = 0;

                private System.Action[] tabActions;

                public void Start()
                {
                        TSys_DPk = Object.FindFirstObjectByType<TABSys_DPk>();
                        if (TSys_DPk == null)
                        {
                                Debug.LogError("TABSys_DPK not found in the scene");
                                return;
                        }
                // Initialize the array with the methods corresponding to each tab
                        tabActions = new System.Action[]
                        {
                                () => TSys_DPk.DisplayAbsol(),
                                () => TSys_DPk.DisplayBeedrill(),
                                () => TSys_DPk.DisplayBlaziken(),
                                () => TSys_DPk.DisplayBraixen(),
                                () => TSys_DPk.DisplayCinderace(),
                                () => TSys_DPk.DisplayDelphox(),
                                () => TSys_DPk.DisplayDragapult(),
                                () => TSys_DPk.DisplayEspeon(),
                                () => TSys_DPk.DisplayFlareon(),
                                () => TSys_DPk.DisplayFrostlass(),
                                () => TSys_DPk.DisplayGarchomp(),
                                () => TSys_DPk.DisplayGardevoir(),
                                () => TSys_DPk.DisplayGlaceon(),
                                () => TSys_DPk.DisplayLeafeon(),
                                () => TSys_DPk.DisplayLopunny(),
                                () => TSys_DPk.DisplayLucario(),
                                () => TSys_DPk.DisplayLunala(),
                                () => TSys_DPk.DisplayMeowscarada(),
                                () => TSys_DPk.DisplayNoivern(),
                                () => TSys_DPk.DisplayPheromosa(),
                                () => TSys_DPk.DisplayPrimarina(),
                                () => TSys_DPk.DisplaySalazzle(),
                                () => TSys_DPk.DisplaySylveon(),
                                () => TSys_DPk.DisplayTsareena(),
                                () => TSys_DPk.DisplayUmbreon(),
                                () => TSys_DPk.DisplayVespiquen(),
                                () => TSys_DPk.DisplayZoroark(),
                                // Add more as needed
                        };
                        // Display the first tab (Introduction) on start
                        DisplayCurrentTab();
                }

                public void NextTab()
                {
                        if (currentTabIndex < tabActions.Length - 1)
                        {
                                currentTabIndex++;
                                DisplayCurrentTab();
                        }
                        else
                        {
                                Debug.Log("You are on the last tab.");
                        }
                }

                public void PreviousTab()
                {
                        if (currentTabIndex > 0)
                        {
                                currentTabIndex--;
                                DisplayCurrentTab();
                        }
                        else
                        {
                                Debug.Log("You are on the first tab.");
                        }
                }

                public void DisplayCurrentTab()
                {
                        DisplayPokemon(tabActions[currentTabIndex]);
                }

                public void DisplayPokemon(System.Action displayMethod)
                {
                        if (TSys_DPk != null)
                        {
                                displayMethod.Invoke();
                        }
                        else
                        {
                                Debug.LogWarning("TABSys_OTBS is not initialized");
                        }
                }
        }
}
