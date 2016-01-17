using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	private Rigidbody rb;
	public float speed;
	public float jump_height;
	public int direction;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () 
	{
		transform.Translate(speed * Time.deltaTime * Input.GetAxis("Horizontal"), jump_height * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
		//GetComponent<SideLock> ().lockZ ();

	}
}
