using project_pkdsim.Assets.Editor.Workspaces;
using UnityEngine;

namespace project_pkdsim.Assets.Editor
{
	public class Project_PkdsimEditor : MonoBehaviour 
	{
		private EditorWorkspaces EditorWorkspaces;
		private void OnEnable()
		{
			EditorWorkspaces.EditorWorkspacesInitializer();
		}
	}
}