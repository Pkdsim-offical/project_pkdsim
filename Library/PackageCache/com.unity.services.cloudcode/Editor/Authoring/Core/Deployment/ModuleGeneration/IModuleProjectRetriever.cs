namespace Unity.Services.CloudCode.Authoring.Editor.Core.Deployment.ModuleGeneration
{
    interface IModuleProjectRetriever
    {
        string GetMainEntryProjectName(string solutionPath);
    }
}
