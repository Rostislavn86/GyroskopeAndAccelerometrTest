using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //https://www.youtube.com/watch?v=lbepitWpD8Q

    Vector3 acceleration = Input.acceleration;

    int speed = 10;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(acceleration.x, 0f, acceleration.y) * speed * Time.deltaTime;
    }
}
