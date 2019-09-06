using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 30f;
    public GameObject restart;
    private int scoreLeft = 0, scoreRight = 0;
    public Text textRight, textLeft;
    private AudioSource audio;

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
       GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
    
        
    


    private void OnCollisionEnter2D(Collision2D collision)
    {      
        if (collision.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (collision.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        speed++;
        if (collision.gameObject.tag == "LeftWall")
        {
            Destroy(gameObject);
            print("Player 1 lose");
            restart.SetActive(true);
            scoreRight++;
            textRight.GetComponent<Text>().text = scoreRight.ToString();  
        }
        if (collision.gameObject.tag == "RightWall")
        {
            //gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            //gameObject.SetActive(false);
            Destroy(gameObject);
            print("Player 2 lose");
            restart.SetActive(true);
            scoreLeft++;
            textLeft.GetComponent<Text>().text = scoreLeft.ToString();
        }
        if (collision.gameObject.tag == "Racket")
        {
            audio.Play();
        }
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

   
}
