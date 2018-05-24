using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float firerate = 10.0f;
    public int bullet_count ;
    public float damage = 10.0f;

    public GameObject player;
    public GameObject bullet;

    public List<GameObject> bullets;
   

	// Use this for initialization
	void Start () {

       // player = GameObject.FindGameObjectWithTag("Player");
      //  bullet = player.transform.GetChild(2).gameObject;

        //bullets = new List<GameObject>();
        //for (int i = 0; i < bullet_count; ++i)
        //{
            
            
        //}

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            //shoot();
            // damage -= 10.0f;
            
           
            InvokeRepeating("Shoot", 0.2f, 0.2f);
        }

	}


    void Shoot()
    {
        transform.Translate(0, 100 * Time.deltaTime, 0);
        
    }

}
