using UnityEngine;
using System.Collections;

public class Improved_camera_follow : MonoBehaviour
{
    public Transform target;
    public float distance = 3.0f;
    public float height = 3.0f;
    public float damping = 5.0f;
    public bool smoothRotation = true;
    public bool followBehind = true;
    public float rotationDamping = 10.0f;

    void FixedUpdate()
    {
        Vector3 wantedPosition;
        if (followBehind)
            wantedPosition = target.TransformPoint(0, height, -distance);
        else
            wantedPosition = target.TransformPoint(0, height, distance);

        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

        if (smoothRotation)
        {
            Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
        }
        else transform.LookAt(target, target.up);
    }
}




//public class Improved_camera_follow : MonoBehaviour
//{

//    public GameObject target;
//    public float movement_speed = 10f;
//    public Vector3 offset;


//    public void Start()
//    {
//        target = GameObject.FindGameObjectWithTag("Player");
//    }

//    public void FixedUpdate()
//    {

//        Vector3 initialpos = target.transform.position + offset;

//        gameObject.transform.position = initialpos;//Vector3.Lerp(transform.position, initialpos, movement_speed * Time.deltaTime);

//        //This is for rotation of the camera
//        //Quaternion wantedRotation = Quaternion.LookRotation(initialpos, target.transform.up);
//        //gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, movement_speed * Time.deltaTime);
//    }

//}