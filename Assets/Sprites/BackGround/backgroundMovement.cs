using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{

    Vector2 initialPosition;
    int initPositionX = -177;
    int endPositionX = 536;
    [SerializeField] float velocity = 10;
    void Start()
    {
        initialPosition = new Vector3(initPositionX, transform.position.y, transform.position.z);
        //-177, 317
        //536, 317
    }

    void Update()
    {

        transform.Translate(new Vector3(velocity, 0, 0) * Time.deltaTime);

        if (transform.position.x > endPositionX)
        {
            transform.position = initialPosition;
        }


    }
}
