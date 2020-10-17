﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour

{
    public Sound[] sounds;

    public static SoundManager instance;

    void Awake() {

        if (instance == null) {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
    {
        DontDestroyOnLoad(gameObject);
    }
     void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
