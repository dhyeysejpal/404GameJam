using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject player;
	public GameObject bullet;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{	
		if (Input.GetKeyDown (KeyCode.X)) 
		{
			//bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			GameObject b = Instantiate (bullet, player.transform.position + new Vector3(0.2f,0,0), Quaternion.identity) as GameObject;
			//b.transform.position = player.transform.position + new Vector3 (0.5f, 0, 0);
			b.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	}
}
