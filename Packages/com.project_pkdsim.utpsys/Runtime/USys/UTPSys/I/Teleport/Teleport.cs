using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.Teleporter
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
        public void TeleportSystemI()
        {
            // Example usage: Teleport to a waypoint named "House1"
            // null by default to avoid errors if no waypoint is specified
            TeleportToWaypoint(null);
        }
    }
}