using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

    private bool pickUpAllowed;

    public Image Auge;

    public Text Gedanke;

    public float lifetime;

    private Collectables collectablesScript;

     void Start ()
     {
        collectablesScript = GameObject.Find("Player").GetComponent<Collectables>();
     }
     
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
        
            Auge.gameObject.SetActive(true);

            Gedanke.gameObject.SetActive(true);

            collectablesScript.myNewInt++;
            Debug.Log("Item wurde aufgehoben und PickUpVariable ist:" + collectablesScript.myNewInt);

    
         Destroy(gameObject);

         Destroy(Gedanke.gameObject, lifetime);
        
    }  

   

}
