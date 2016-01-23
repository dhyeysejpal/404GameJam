using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	private Rigidbody rb;
	public float speed;
	public float jump_height;
	public int direction;
	 GameObject puke;
	public int h_speed;
	public int v_speed;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();		
		puke = GameObject.FindGameObjectWithTag("Puke");
	}

	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		puke.transform.Rotate (horizontal * h_speed, v_speed * vertical, 0);

		if (Input.GetKey (KeyCode.X)) 
		{
			transform.Translate(-horizontal * speed * Time.deltaTime, -1.5f*speed * vertical* Time.deltaTime, 0);
			puke.SetActive (true);
		} 
		else 
		{		
			transform.Translate(speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);
			puke.SetActive (false);

		}

	}
}
