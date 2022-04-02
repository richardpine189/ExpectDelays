using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] List<GameObject> _obstacles;
    [SerializeField] List<GameObject> _pickUpObjects;
    [SerializeField] Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SimpleSpawn", 2, 3);


    }

    private void SimpleSpawn()
    {
        int randomObstacle = Random.Range(0, _obstacles.Count);
        Instantiate(_obstacles[randomObstacle], initialPosition, Quaternion.identity);
    }

}
