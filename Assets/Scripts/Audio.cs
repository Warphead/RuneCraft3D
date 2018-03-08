using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public AudioClip SoundChip;
    public AudioClip SoundCard;
    public AudioClip SoundClick;
    public AudioClip Music;
    public AudioSource audio;
    //public AudioSource audio2;
    public float SoundVolume;
    public float MusicVolume;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        //audio2 = GetComponent<AudioSource>();
        SoundVolume = 0.7F;
        MusicVolume = 0.7F;



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySoundChip()
    {
        audio.PlayOneShot(SoundChip, SoundVolume);
    }
    public void PlaySoundCard()
    {
        audio.PlayOneShot(SoundCard, SoundVolume);
    }
    public void PlaySoundClick()
    {
        audio.PlayOneShot(SoundClick, SoundVolume);
    }
    public void PlayMusic()
    {
        audio.PlayOneShot(Music, MusicVolume);
        //audio.loop = true;
    }
}
