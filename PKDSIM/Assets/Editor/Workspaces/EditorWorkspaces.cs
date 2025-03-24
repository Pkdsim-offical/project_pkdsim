using project_pkdsim.Assets.Editor.Workspaces.Namespace.Exporter;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces
{
	public class EditorWorkspaces : MonoBehaviour 
	{
		private NamespaceExporter namespaceExporter;
		private Editor_AAsys editor_AAsys;
		private void Init() 
		{
			namespaceExporter.ExportNamespaces();
			editor_AAsys.Editor_AAsysI();
		}

		public void EditorWorkspacesInitializer() 
		{
			Init();
		}
	}
}