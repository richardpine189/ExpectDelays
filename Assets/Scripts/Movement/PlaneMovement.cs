using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] Vector3 directionPlanes;

    void Start()
    {
        character.SetActive(false);
    }

    void Update()
    {
        transform.Translate(directionPlanes * Time.deltaTime);

        if (transform.position.x > character.transform.position.x)
        {
            character.SetActive(true);
        }
    }
}
