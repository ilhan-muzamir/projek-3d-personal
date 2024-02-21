using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource soundPlayer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayThisMusic() 
    {
        soundPlayer.Play();
    }

    public void StopThisMusic()
    {
        soundPlayer.Stop();
    }
}
