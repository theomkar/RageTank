using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public GameObject player;
    public GameObject bullet;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        bullet = player.transform.GetChild(2).gameObject;

	}
	
	// Update is called once per frame
	void Update () {
		//bullet.transform
	}
}
