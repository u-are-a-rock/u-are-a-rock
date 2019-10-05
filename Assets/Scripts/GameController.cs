﻿using System.Collections;
using UnityEngine.Audio;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Sound[] sounds;

    public static GameController instance;


    [HideInInspector]
    public GameObject MainMenu;
    [HideInInspector]
    public GameObject CreditsMenu;
    [HideInInspector]
    public GameObject OptionsMenu;
    [HideInInspector]
    public GameObject Canvas;

    [HideInInspector]
    public GameObject DirectionalLight;

    [HideInInspector]
    public float timer;

    private void Awake()
    {
        //Sets instance to this script if there are no others, but destroys the gameobject if the script is not the only one there
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); return; }
        DontDestroyOnLoad(gameObject);


        Canvas = GameObject.Find("Canvas");
        MainMenu = GameObject.Find("Main Menu");
        CreditsMenu = GameObject.Find("Credits Menu");
        OptionsMenu = GameObject.Find("Options Menu");
        DirectionalLight = GameObject.Find("Directional Light");
        CreditsMenu.SetActive(false);
        OptionsMenu.SetActive(false);



        //Audio Controller Section
        foreach (Sound s in sounds)
        {
            if (GameObject.Find(s.name) != null)
            { s.source = GameObject.Find(s.name).AddComponent<AudioSource>(); }
            else { s.source = gameObject.AddComponent<AudioSource>(); }

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.spatialBlend = s.spatialBlend;
        }
    }

    public void Update()
    {
        timer += Time.deltaTime;
    }

    public void Play(string name)
    {
        //Checks sounds array for a sound(scripts) with name = to the string name and sets it to s
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found");
            return;
        }

        s.source.Play();
    }

    public void MasterVolume(int masterVolume, int effectVolume, int musicVolume)
    {
        foreach (Sound s in sounds)
        {
            if (s.music == true) { s.source.volume = s.volume * masterVolume * musicVolume; }
            else { s.source.volume = s.volume * masterVolume * effectVolume; } 
        }
    }
   
}
