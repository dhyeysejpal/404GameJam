using UnityEngine;
using System.Collections;

public class SideLock : MonoBehaviour {

	public float initZ;
	public int previousZ;

	// Use this for initialization
	void Start () {
		initZ = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y,initZ);
	}

	public void lockZ () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, initZ);
	}
}
