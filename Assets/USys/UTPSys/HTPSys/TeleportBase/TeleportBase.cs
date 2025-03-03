using UnityEngine;

namespace project_pkdsim.Assets.USys.TPSys.UHousesTeleporterSys.TeleportBase
{
    public class TeleportSystem : MonoBehaviour
    {
        [System.Serializable]
        public struct Waypoint
        {
            public string name;
            public Transform location;
        }

        public Waypoint[] waypoints; // Assign in Inspector

        public void TeleportToWaypoint(string waypointName)
        {
            foreach (Waypoint waypoint in waypoints)
            {
                if (waypoint.name == waypointName)
                {
                    Transform player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player
                    player.position = waypoint.location.position;
                    return;
                }
            }
            Debug.LogWarning($"Waypoint '{waypointName}' not found!");
        }
    }
}