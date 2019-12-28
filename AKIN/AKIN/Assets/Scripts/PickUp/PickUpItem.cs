using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

    private bool pickUpAllowed;

    public Image Auge;
    // public bool collided = false;


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
        //if (Auge != null)
        //{
            Auge.gameObject.SetActive(true);
        //}
        Destroy(gameObject);
    }
}
