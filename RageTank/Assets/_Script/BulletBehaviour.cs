﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float firerate = 10.0f;
    public int bullet_count ;
    public float damage = 10.0f;
    public float speed = 10f;
    bool start = false;

    public GameObject player;
    Rigidbody rb;
   

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
       
       //To set the position of this object i.e(Bullet) with player 
       // rb.transform.position = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Shoot();  
    }


    void Shoot()
    {
        transform.position += transform.forward * speed * Time.deltaTime;   
        transform.parent = null;
        StartCoroutine("DestroyBullet");
    }

    


    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }

   

}
