using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public int myNewInt = 0;

    public Collider2D SpawnHare;
    
    void Start ()
    {
        
        myNewInt++;

        if(myNewInt == 10)
        {
           SpawnHare.gameObject.SetActive(true);
        
        }else
        {
            SpawnHare.gameObject.SetActive(false);
        }

        
    }


}
