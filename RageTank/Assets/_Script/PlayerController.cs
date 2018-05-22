using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 10.0f;
    private Vector3 moveDir;
    Rigidbody m_rigidbody;

    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
	}

    private void FixedUpdate()
    {
        m_rigidbody.MovePosition(m_rigidbody.position + transform.TransformDirection(moveDir) * movementSpeed * Time.deltaTime);   
    }
}
