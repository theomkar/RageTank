using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedBody : MonoBehaviour {

    
    public PlanetGravity gravity;

    Rigidbody m_rigidbody;

	// Use this for initialization
	void Start () {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        m_rigidbody.useGravity = false;

        
	}
	
	// Update is called once per frame
	void Update () {

        gravity.Attract(transform);
	}
}
