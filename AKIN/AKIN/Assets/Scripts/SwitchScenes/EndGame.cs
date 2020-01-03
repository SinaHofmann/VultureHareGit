using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public VideoPlayer VideoPlayer;

    
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }
    
    void LoadScene(VideoPlayer VP)
    {
        SceneManager.LoadScene(0);
    }
   
}
