using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] Vector3 directionPlanes;
    AudioSource source { get { return GetComponent<AudioSource>(); } }
    [SerializeField] AudioClip clip;


    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = clip;
        character.SetActive(false);

    }

    void Update()
    {
        transform.Translate(directionPlanes * Time.deltaTime);

        if (transform.position.x > character.transform.position.x)
        {
            character.SetActive(true);
            source.Play();
        }

        if (transform.position.x > 20)
        {
            Destroy(gameObject);

        }

    }
}
