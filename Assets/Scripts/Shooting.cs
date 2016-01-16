using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour 
{

	public GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Capsule);
	public GameObject player;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if (Input.GetKeyDown (KeyCode.X)) 
		{
			Instantiate (bullet, GunPosition, Quaternion.identity);
		}
	}
}
