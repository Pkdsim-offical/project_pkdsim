using UnityEngine.UIElements;

namespace Unity.Services.Deployment.Editor.Interface.UI.Events
{
    class DeployAllClicked : EventBase<DeployAllClicked>
    {
        public static void Send(VisualElement sender)
        {
            using var evt = GetPooled();
            evt.target = sender;
            sender.SendEvent(evt);
        }
    }
}
