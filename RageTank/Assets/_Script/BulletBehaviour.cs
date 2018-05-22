using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public GameObject player;
    public GameObject bullet;

    public float firerate = 10.0f;
    public int bullet_count ;
    public float damage = 10.0f;

    public List<GameObject> bullets;
   

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        bullet = player.transform.GetChild(2).gameObject;

        //for(int i = 0; i < bullet_count; ++i )
        //{
        //    bullets = new List<GameObject>();
        //}

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            //shoot();
            // damage -= 10.0f;
            
            transform.Translate(0, 100 * Time.deltaTime, 0);
        }

	}


    void shoot()
    {

    }

}
