using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_Actor : MonoBehaviour
{
    float speed = 0.2f;
    public Transform target;
    //public List<Transform> WayPoint;
    // Start is called before the first frame update
    void Start()
    {
      transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));  
    }
    void Update()
    {
        transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
        transform.Translate(new Vector3(0,0,speed*Time.deltaTime));
    }
    /* void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "WayPoint")
        {
            
            Debug.Log("entre");
            target = other.gameObject.GetComponent<WayPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
        }
    } */
    void OnTriggerEnter(Collider other) 
    {
        speed = 0f;
    }
}
