﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundContinously : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private static PlaySoundContinously  instance = null;
    public static PlaySoundContinously  Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
} 