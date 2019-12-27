using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewLevel : MonoBehaviour
{
    
    public Transform Spawnpoint;
    public GameObject NewArea;
    
    void OnTriggerEnter2D ()
    {
        Instantiate(NewArea, Spawnpoint.position, Spawnpoint.rotation);
    }
}
