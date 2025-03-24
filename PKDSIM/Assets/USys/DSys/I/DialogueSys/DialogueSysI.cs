using project_pkdsim.Assets.USys.DialogueSys.I.Load_Negative_Dialogue;
using project_pkdsim.Assets.USys.DialogueSys.I.Load_Neutral_Dialogue;
using project_pkdsim.Assets.USys.DialogueSys.I.Load_Positive_Dialogue;
using project_pkdsim.Assets.USys.DSys.I.DialogueSys.LoadImmuneDialogue;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score;
using TMPro;
using UnityEngine;

namespace project_pkdsim.Assets.USys.DialogueSys.I
{
	public class DialogueSysI : MonoBehaviour 
	{
		private GameObject DialogueBackground;
		private bool DialogueActivated = false;
		private TextMeshProUGUI DialogueText;
		private AffectionScore NPC_LOVESys;

		private LoadNeutralDialogue Load_NeutralDialogue;
		private LoadPositiveDialogue Load_PositiveDialogue;
		private LoadNegativeDialogue Load_NegativeDialogue;

		private LoadImmuneDialogue Load_ImmuneDialogue;

		public void LoadDialogueSys() 
		{
			Load_DialogueBackground();
		}

		private bool Load_DialogueBackground() 
		{

			if(DialogueBackground != null && DialogueText != null && NPC_LOVESys != null)
			{
				// Non-null, Non-null, Non-null
				Load_Dialogue();
				return true;
			}

			else if(DialogueBackground == null && DialogueText != null && NPC_LOVESys != null)
			{
				// null, Non-null, Non-null
				Debug.Log("DialogueText is Active but DialogueBackground is not.");
			}

			else if(DialogueBackground != null && DialogueText == null && NPC_LOVESys != null)
			{
				// Non-null, null, Non-null
				Debug.Log("DialogueBackground is Active but DialogueText is not.");
			}

			else if(DialogueBackground == null && DialogueText != null && NPC_LOVESys == null)
			{
				// null, Non-null, null
				Debug.Log("DialogueText is Active and NPC_LOVESys is Active but DialogueBackground is not.");
			}

			else if(DialogueBackground != null && DialogueText == null && NPC_LOVESys == null)
			{
				// Non-null, null, null
				Debug.Log("DialogueBackground is Active but DialogueText is Null and NPC_LOVESys is Null.");
			}

			else if(DialogueBackground == null && DialogueText == null && NPC_LOVESys != null)
			{
				// null, null, Non-null
				Debug.Log("NPC_LOVESys is Active but DialogueBackground and DialogueText are Null.");
			}

			else if(DialogueBackground == null && DialogueText == null && NPC_LOVESys == null)
			{
				// null, null, null
				Debug.Log("DialogueBackground and DialogueText and NPC_LOVESys are all Null.");
			}
			return false;
		}

		private void Load_Dialogue()
		{
			if(Load_DialogueBackground() == true) 
			{
				Load_DialogueValues();
			}

			else
			{
				Debug.Log("Disabled or not Actionable");
			}
		}
		private void Load_DialogueValues()
		{
			// negative, neutral, positive, immune
			if (NPC_LOVESys.Affection_ITEMSSys_BASE(false, false, false, false))
			{
				Load_Neutral_Dialogue();
				Load_Positive_Dialogue();
				Load_Negative_Dialogue();
			}
		}
		private void Load_Neutral_Dialogue()
		{
			// negative, neutral, positive, immune
			if (NPC_LOVESys.Affection_ITEMSSys_BASE(false, true, false, false))
			{
				Load_NeutralDialogue.LoadNeutralDialogueI();
			}
		}
		private void Load_Positive_Dialogue()
		{
			// negative, neutral, positive, immune
			if (NPC_LOVESys.Affection_ITEMSSys_BASE(false, false, true, false))
			{
				Load_PositiveDialogue.LoadPositiveDialogueI();
			}
		}
		private void Load_Negative_Dialogue()
		{
			// negative, neutral, positive, immune
			if (NPC_LOVESys.Affection_ITEMSSys_BASE(true, false, false, false))
			{
				Load_NegativeDialogue.LoadNegativeDialogueI();
			}
		}
		private void Load_Immune_Dialogue() 
		{
			// negative, neutral, positive, immune
			if (NPC_LOVESys.Affection_ITEMSSys_BASE(false, false, false, true))
			{
				Load_ImmuneDialogue.LoadImmuneDialogueI();
			}
		} 
		public void DialogueSys_I()
		{
			LoadDialogueSys();
		}
	}
}