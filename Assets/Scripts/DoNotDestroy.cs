using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
}
