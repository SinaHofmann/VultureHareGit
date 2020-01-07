using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnHare : MonoBehaviour
{
   public GameObject Hare;

   private float LoadDelay = 1.0f;


   
   
   void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.name.Equals("Player"))
      {
          
           Hare.gameObject.SetActive(true);

           Invoke("LoadScene", LoadDelay);

      }
           
   }
   void LoadScene ()
   {
      SceneManager.LoadScene(3);
   }

}