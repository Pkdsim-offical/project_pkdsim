using System.Threading.Tasks;

namespace Unity.Services.CloudCode.Authoring.Editor.Deployment
{
    interface IDashboardUrlResolver
    {
        Task<string> CloudCodeScript(string name);
        Task<string> CloudCodeModule(string name);
    }
}
