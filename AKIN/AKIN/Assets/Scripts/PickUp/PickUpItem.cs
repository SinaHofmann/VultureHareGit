using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

   // private GameObject UICounter;
    private bool pickUpAllowed;

    
    //void Start ()
    //UICounter = GameObject.Find("Instatiate").GetComponent<UICounter>();}
    


    private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player")) 
        {
           
            pickUpAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
          
            pickUpAllowed = false;
        }
    }

    void PickUp()
    {
        Destroy(gameObject);
    }
}
