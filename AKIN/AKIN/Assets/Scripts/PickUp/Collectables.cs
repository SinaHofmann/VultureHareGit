using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public int myNewInt = 0;

    public Collider2D SpawnHare;

    public GameObject AugenLeuchten;
    public GameObject AugenLeuchten2;

    void Start ()
    {
        myNewInt = 0;

        SpawnHare.gameObject.SetActive(false);

    
    }

    void Update ()
    {
        if(myNewInt == 10)
        {
            AugenLeuchten.gameObject.SetActive(true); 
            AugenLeuchten2.gameObject.SetActive(true);

            SpawnHare.gameObject.SetActive(true);
            Debug.Log("SpawnHare ist erschienen - Die PickUpVariable zeigt:" + myNewInt);
        }

    }



       
        

        
        
        

        

        

        
    


}
