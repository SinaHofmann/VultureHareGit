using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHare : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Hare;


    
    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
           
           Instantiate(Hare, Spawnpoint.position, Spawnpoint.rotation);  
        }
       
    }
}
