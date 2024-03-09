using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    public AudioSource AudioSource;
    private float musicvolume = 1f;
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicvolume;
    }
    public void updatevolume (float volume)
    {
        musicvolume = volume;
    }
}
