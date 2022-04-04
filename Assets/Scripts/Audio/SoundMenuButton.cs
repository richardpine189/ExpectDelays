using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMenuButton : MonoBehaviour
{
    AudioSource source { get { return GetComponent<AudioSource>(); } }
    Button button { get { return GetComponent<Button>(); } }

    [SerializeField] AudioClip clip;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        button.onClick.AddListener(PlaySound);
    }

    private void PlaySound()
    {
        source.PlayOneShot(clip);
    }

}

