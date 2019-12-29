using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HinweisTextMitte : MonoBehaviour
{
   public Text Text;

   void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.name.Equals("Player"))
      {
           Text.gameObject.SetActive(true);
           
      }
   }
   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
          
           Text.gameObject.SetActive(false);

            
        }
    }
}
