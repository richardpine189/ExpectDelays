using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float destroyPosition;

    private void Update()
    {
        if(transform.position.y < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
