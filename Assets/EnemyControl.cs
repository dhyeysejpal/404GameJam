using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	public LevelControl lvlCtrl;
	public int hp = 1;
	public bool isDead;
	public int ammoWorth = 25;

	// Use this for initialization
	void Start () {
		lvlCtrl = GameObject.Find ("LevelControl").GetComponent<LevelControl> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void takeDamage (int dmg){
		hp -= dmg;
		if (hp < 1) {
			isDead = true;
			death ();
		}
	}

	void death (){
		lvlCtrl.decreaseEnemy();
		lvlCtrl.ammo += ammoWorth;
		//GetComponent<Renderer> ().material.color = Color.red;
		//GetComponent<Rigidbody> ().isKinematic = true;
		//GetComponent<Collider> ().isTrigger = true;
		gameObject.SetActive(false);



		//set to kinematic
		//disable rigidbody
		//play dying animation
		//play dead animation
		//add to score
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Bullet"))
		{
			other.gameObject.SetActive (false);
			takeDamage (other.GetComponent<BulletControl>().dmg);
		}
		else if(other.gameObject.CompareTag ("Player"))
		{
			Application.LoadLevel("Level1");
		}
	}

}
