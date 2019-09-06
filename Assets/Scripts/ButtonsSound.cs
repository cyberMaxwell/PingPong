using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsSound : MonoBehaviour
{
    public Sprite soundOff, soundOn;

    public void buttonsSound()
    {
       
            if (AudioListener.volume == 0)
            {
                GetComponent<Image>().sprite = soundOn;

                AudioListener.volume = 1;
            }
            else
            {
                GetComponent<Image>().sprite = soundOff;

                AudioListener.volume = 0;
            }
    }
}
