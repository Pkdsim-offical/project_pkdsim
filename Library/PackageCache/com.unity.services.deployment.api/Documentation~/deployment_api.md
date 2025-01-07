
## Integrating with the Deployment Window

Once the Deployment API assembly is referenced,
a DeploymentProvider can be registered or unregistered from the 
Deployment class at any time.

```
  [InitializeOnLoadMethod]
  static void Initialize()
  {
      var myServiceDeploymentProvider = new MyServiceDeploymentProvider();
      Deployments.Instance.DeploymentProviders.Add(myServiceDeploymentProvider);
  }
```

The Deployments API follows a strict observer pattern. 
To add a deployment item to the window, simply add it to the collection,
and to remove an item, simply remove it from the collection.  

The same is true for commands, which are available contextually.

Obtaining registered services and commands can be done programatically the same.

### Sample Code
```
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unity.Services.DeploymentApi.Editor;
using UnityEditor;
using UnityEngine;

namespace SampleProvider
{
    class MyServiceDeploymentProvider : DeploymentProvider
    {
        public override string Service => "MyService";

        public override Command DeployCommand { get; }

        public MyServiceDeploymentProvider()
        {
            DeployCommand = new MyDeployCommand();

            //Example way of obtaining files
            var serviceFiles = Directory
                .GetFiles(
                Application.dataPath,
                "*.cs", 
                SearchOption.AllDirectories);

            foreach (var filePath in serviceFiles)
            {
                DeploymentItems.Add(new DeploymentItem()
                {
                    Path = filePath,
                    Name = Path.GetFileName(filePath)
                });
            }
        }

        class MyDeployCommand : Command<DeploymentItem>
        {
            public override string Name => "Deploy";
            public override async Task ExecuteAsync(
                IEnumerable<DeploymentItem> deploymentItems,
                CancellationToken cancellationToken = default)
            {
                // User selected deployment environment
                var environment = Deployments.Instance.EnvironmentProvider.Current;
                var token = CloudProjectSettings.accessToken;

                foreach (DeploymentItem item in deploymentItems)
                {
                    item.Progress = 0;
                    item.Status = new DeploymentStatus("Deploying");

                    await Task.Delay(1000);

                    item.Progress = 50;

                    await Task.Delay(1000);

                    item.Progress = 100;
                    item.Status = DeploymentStatus.UpToDate;
                }
            }
        }
    }
}
```

## Accessing Registered Implementations

The ideal usage of the registered functoinality is through the [deployment API](./deployment_api.md)
or the Deployment Window itself, however, if you'd like to access specific functionality
you may do so manually.  

For example, suppose we want to obtain and execute the "Upload" command
from the "Multiplay" service:`
