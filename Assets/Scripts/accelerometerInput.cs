using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometerInput : MonoBehaviour
{
    float speed = 10f;
    // Update is called once per frame
    void FixedUpdate(){
         Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, 0.0f);
         GetComponent<Rigidbody>().velocity = movement * speed;
     }

}