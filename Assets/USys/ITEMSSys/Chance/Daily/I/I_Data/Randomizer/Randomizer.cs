using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.Chance.Daily.I.I_Data.Randomizer
{
	public class ItemsChanceDaily_Randomizer : MonoBehaviour 
	{	
		
		public void ItemsChanceDailyRandomizer()
		{
			int randomRange = Random.Range(1, 101); // Integer between 1 and 100
			float randomFloat = Random.Range(0f, 1f); // Float between 0.0 and 1.0
			Debug.Log($"Random Integer (1-100): {randomRange}");
			Debug.Log($"Random Float (0-1): {randomFloat}");
		}
	}
}