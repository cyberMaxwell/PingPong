using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameObject ball;

    private float speed = 4.5f;

    void Update()
    {
        if(ball.gameObject != null)
        transform.position = Vector2.Lerp(new Vector2(23, transform.position.y), new Vector2(23, ball.transform.position.y), speed * Time.deltaTime);
        speed += .00004f;

    }
}
