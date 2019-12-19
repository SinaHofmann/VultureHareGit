using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICounter : MonoBehaviour 
{

    public GameObject canvasPanel;
    public GameObject inventorySlot;

    public void CountUp(){
        GameObject addImageToCanvas = Instantiate(inventorySlot);
        addImageToCanvas.transform.SetParent(canvasPanel.transform, false);
    }
}
