using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{ 
    [Header("-----AudioSource-----")]
    [SerializeField] AudioSource Musicsource;
    [SerializeField] AudioSource Sfxsource;
    [Header("-----AudioClip-----")]
    public AudioClip hitAplle;
    public AudioClip hitBottle;
    public AudioClip win;
    public AudioClip Background;
    // Start is called before the first frame update
    void Start()
    {
        Musicsource.clip = Background;
        Musicsource.Play();
    }

    public void Playsfx(AudioClip clip)
    {
        Sfxsource.PlayOneShot(clip);
    }
    public void puse()
    {
        Musicsource.Pause();
    }
}
