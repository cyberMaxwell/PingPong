using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   // private MainMenuScript mainMenuScript;
   // 
   // public GameObject[] all, buttons;
   // private Bot bot;
   // private MoveRacket moveRacket;
   // public GameObject racketRight;
   // public GameObject ball;
   
    //private void Start()
    //{
    //    mainMenuScript = gameObject.GetComponent<MainMenuScript>();
    //    bot = GetComponent<Bot>();
    //    moveRacket = GetComponent<MoveRacket>();
    //}
    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
       //for(int i = 0; i < buttons.Length; i++)
       //{
       //    buttons[i].SetActive(false);
       //}
       //
       //
       //    SetActiveAll();
       //    racketRight.GetComponent<MoveRacket>().enabled = true;
    }

   // void SetActiveAll()
   // {
   //     ball.SetActive(true);
   //     ball.GetComponent<BoxCollider2D>().isTrigger = false;
   //     ball.transform.position = new Vector2(0, 0);
   //     ball.GetComponent<Rigidbody2D>().velocity = Vector2.left * 30f;
   //    
   //     for (int i = 0; i < all.Length; i++)
   //     {
   //         all[i].SetActive(true);
   //     }
   // }

   
}
