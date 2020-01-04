using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnHare : MonoBehaviour
{
     public GameObject Hare;



   void OnTriggerEnter2D(Collider2D collision)
   {
      
      if (collision.gameObject.name.Equals("Player"))
      {
           Hare.gameObject.SetActive(true);
          
           SceneManager.LoadScene(3);
           
      }
   }
   
}  




