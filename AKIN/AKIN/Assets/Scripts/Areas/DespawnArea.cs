using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnArea: MonoBehaviour
{
     public GameObject Area;

   void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.name.Equals("Player"))
      {
           Area.gameObject.SetActive(false);
           
      }
   }
}
