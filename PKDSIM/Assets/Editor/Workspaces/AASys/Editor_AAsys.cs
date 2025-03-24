using project_pkdsim.Assets.Editor.Workspaces.AASys.I;

namespace project_pkdsim.Assets.Editor.Workspaces
{
	public class Editor_AAsys : Editor_AASysI 
	{
		private void AASys_Initializer()
		{
			AASys_Init();
		}
		public void Editor_AAsysI() 
		{
			AASys_Initializer();
		}
	}
}