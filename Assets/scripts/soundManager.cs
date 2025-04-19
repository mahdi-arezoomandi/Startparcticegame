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
    public AudioClip Win;
    public AudioClip Background;
    // Start is called before the first frame update
    void Start()
    {
        Musicsource.clip = Background;
        Musicsource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
