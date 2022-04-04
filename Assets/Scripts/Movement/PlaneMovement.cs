using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] GameObject _character;
    [SerializeField] GameObject _spawner;
    [SerializeField] GameObject _timer;
    [SerializeField] Vector3 _directionPlanes;


 

    void Update()
    {
        transform.Translate(_directionPlanes * Time.deltaTime);

        if (transform.position.x > _character.transform.position.x)
        {
            _character.SetActive(true);
            _timer.SetActive(true);
            StartCoroutine(ActiveSpawner());
        }

        if (transform.position.x > 20)
        {
            Destroy(gameObject);

        }

    }
    private IEnumerator ActiveSpawner()
    {
        yield return new WaitForSeconds(2);
        _spawner.SetActive(true);
    }
}
