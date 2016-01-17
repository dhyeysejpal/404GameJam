using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour 
{

	public GameObject player;
	public GameObject bullet;
	public float speed = 100f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{	
		if (Input.GetKeyDown (KeyCode.X)) 
		{
			bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Instantiate (bullet, player.transform.position + new Vector3(0.5f,0,0), Quaternion.identity);
			bullet.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	}
}