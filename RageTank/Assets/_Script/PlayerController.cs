using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 20.0f;
    public float turnRate = 5.0f;
    private Vector3 moveDir;
    Rigidbody m_rigidbody;

    Transform m_transform;
    public GameObject bulletprefab;

    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        bulletprefab = Resources.Load("Bullets") as GameObject;
    }

    // Update is called once per frame
    void Update () {
        moveDir = new Vector3(0, 0, Input.GetAxis("Vertical")).normalized;
        m_transform = GetComponent<Transform>();

        if (Input.GetKey("a"))
        {
            Debug.Log("a pressed");
            this.transform.Rotate(0, Time.deltaTime - turnRate, 0, Space.World);
        }

        if (Input.GetKey("d"))
        {
            Debug.Log("a pressed");
            this.transform.Rotate(0, Time.deltaTime + turnRate, 0, Space.World);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
        }

    }

    void CreateBullet()
    {
        Instantiate(bulletprefab,gameObject.transform.position,Quaternion.identity);
        
    }

    private void FixedUpdate()
    {
        m_rigidbody.MovePosition(m_rigidbody.position + transform.TransformDirection(moveDir) * movementSpeed * Time.deltaTime);
     
    }
}
