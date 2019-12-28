using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHare : MonoBehaviour
{
     public GameObject Hare;

   void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.name.Equals("Player"))
      {
           Hare.gameObject.SetActive(true);
           
      }
   }
}
