using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBehaviour : MonoBehaviour
{
    [SerializeField] float velocity;
    int upLimitScreeen = 15;
    int downLimitScreeen = -15;


    void Update()
    {
        transform.position += new Vector3(0, velocity, 0) * Time.deltaTime;


        if (transform.position.y > upLimitScreeen)
        {

            Destroy(gameObject);
        }

        if (transform.position.y < downLimitScreeen)
        {
            Destroy(gameObject);
        }
    }

}
