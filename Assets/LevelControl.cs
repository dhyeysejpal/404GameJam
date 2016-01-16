using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour {

	public int ammo = 100;
	public int enemiesLeft=0;
	public int initEnemiesCount;

	public GameObject ammoGui;
	public GameObject EnemyCntGui;

	// Use this for initialization
	void Start () {
		ammo = 100;
		ammoGui = GameObject.Find ("AmmoGUI");
		EnemyCntGui = GameObject.Find ("EnemyCntGUI");
		initEnemiesCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
		enemiesLeft = initEnemiesCount;
	}
	
	// Update is called once per frame
	void Update () {
		ammoGui.GetComponent<Text> ().text = "Ammo:" + ammo.ToString();
		EnemyCntGui.GetComponent<Text> ().text = "Enemies Left:" + enemiesLeft.ToString() + "/" + initEnemiesCount.ToString();
	
	}

	public void decreaseEnemy(){
		enemiesLeft--;
	}
}
