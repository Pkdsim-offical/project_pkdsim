using UnityEngine;

public class PkPhone_Item : MonoBehaviour
{
	private UnityEngine.GameObject pkphone;
	public void Get_Game_object()
	{
		pkphone = GameObject.Find("PkPhone");
	}

}