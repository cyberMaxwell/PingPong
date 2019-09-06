using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{  
    public GameObject[] all, otherButtons;
    public GameObject racketRight, wallRacket;
    private MoveRacket moveRacket;
    private Bot bot;
    [HideInInspector]
    public static int a;
    private void Start()
    {
        moveRacket = gameObject.GetComponent<MoveRacket>();
        bot = gameObject.GetComponent<Bot>();
    }

    public void OnePlayer()
    {
        SetVisibleAll();
        racketRight.GetComponent<Bot>().enabled = true;
        wallRacket.SetActive(false);
        a = 0;
        
    }
    public void TwoPlayers()
    {
        SetVisibleAll();
        racketRight.GetComponent<MoveRacket>().enabled = true;
        wallRacket.SetActive(false);
        a = 1;
    }

    public void WallMode()
    {
        SetVisibleAll();
        racketRight.SetActive(false);
    }

    
  
    void SetVisibleAll()
    {
        for (int i = 0; i < all.Length; i++)
        {
            all[i].SetActive(true);
        }
        gameObject.SetActive(false);
        for(int i = 0; i< otherButtons.Length; i++)
        {
            otherButtons[i].SetActive(false);
        }

    }

}
