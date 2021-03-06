﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundList
{
    PlayerJump,
    DarkModeSwitchSound1,
    DarkModeSwitchSound2,
    DarkModeSwitchSound3,
    Impact1,
    Impact2,
    KeyUnlock
}

[System.Serializable]
public class Sound
{
    // as we are going to add audio in the AudioManager gameObject, we need a reference
    public AudioClip clip;
    public SoundList soundList;
    [HideInInspector] public AudioSource source;
    [Range(0f, 2f)] public float volume;
    [Range(0.1f, 3f)] public float pitch;
    // determine 2D or 3D sound.
    [Range(0f, 1f)] public float reverbZoneMix;

}
