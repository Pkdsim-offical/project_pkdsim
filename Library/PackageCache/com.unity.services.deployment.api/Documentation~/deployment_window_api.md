## Deployment Window API

The Deployment Window API allows you to access the basic operations of the 
Deployment Window programatically. 

The api documentation goes into details on each operation.

Below are few examples on how to achieve some basic operations:

### Deploy All Items

```
var dwapi = Deployments.Instance.DeploymentWindow;
var items = dwapi.GetAllDeploymentItems();
await dwapi.Deploy(items);
```

### Check a Given Item

```
var dwapi = Deployments.Instance.DeploymentWindow;
var items = dwapi.GetFromFiles(new[] {"Assets/my_file.js"});
dwapi.Check(items);

await dwapi.Check(items);
```

### Deploy an item by Path

```
var dwapi = Deployments.Instance.DeploymentWindow;
await dwapi.Deploy(new[] {"Assets/my_file.js"});
```

### Trigger code before a deployment is made

```
Deployments.Instance.DeploymentWindow.DeploymentStarting += list =>
{
    Debug.Log("Deployment starting");
};
```

### Dependency Resolution

Declared dependencies are resolved during deployment time, and cleared after.
They're populated if and only if they're part of the deployment.

e.g.:
```
var dwapi = Deployments.Instance.DeploymentWindow;
var items = dwapi.GetFromFiles(new[] {"Assets/my_file.xyz"});
var deploymentTask = dwapi.Deploy(items);
// This will be populated during deployment
var deps = (items[0] as IDependentItem).ResolvedDependencies; 
await deploymentTask;
//deps will be cleared here, since deployment will be complete
```

To implement dependency resolution, a IDeploymentItem must declare its dependencies.

e.g.:
```
class MyItem : IDependentItem {
  public IReadOnlyList<IDependency> Dependencies { get; set; } = Array.Empty<IDependency>();
  public List<IDeploymentItem> ResolvedDependencies { get; } = new List<IDeploymentItem>();
}

var item = new MyItem() {
  Dependencies = new[] { new NamedDependency() { ResourceName = "someItem" } } 
}

```

Before deployment, the NamedDependency will be resolved, if possible, and
then the client may wait on the dependency if applicable, or observe its other
properties.  
Dependencies are resolved, but not awaited or treated in any other particular fashion.

By default, two types of IDependency are given, `NamedDependency` and `IdentifiedDependency`
capable of resolving `INamedResource` and `IIdentifiable`, recursively over `ICompositeItem`.

These are used to address cross-service resource dependencies internally.

Custom dependency resolution can be implemented by clients by implementing
`IDependency` class and its method `Resolve`.
If necessary, they should also look recursively over `ICompositeItem`.
