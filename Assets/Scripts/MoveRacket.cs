using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";
  
    
    void FixedUpdate()
    {
      
        float v = Input.GetAxis(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        speed += .004f;
    }
  
}
