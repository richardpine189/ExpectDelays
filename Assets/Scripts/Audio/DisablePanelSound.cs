using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePanelSound : MonoBehaviour
{
    AudioSource source { get { return GetComponent<AudioSource>(); } }

   // [SerializeField] AudioClip clip;
    
    private void Start()
    {
       // gameObject.AddComponent<AudioSource>();

       // source.clip = clip;
    }

    public void OnDisable()
    {
        source.Play();
    }


}
