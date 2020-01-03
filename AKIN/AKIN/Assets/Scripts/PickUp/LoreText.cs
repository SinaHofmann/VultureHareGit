using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreText : MonoBehaviour
{
    public Image Text;
    private bool pickUpAllowed;

  


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

            Text.gameObject.SetActive(false);

            
        }
    }

    void PickUp()
    {
        
        Text.gameObject.SetActive(true);

       
    }  
   
}
