using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] List<GameObject> _obstacles;
    [SerializeField] List<GameObject> _pickUpObjects;
    [SerializeField] List<GameObject> _clouds;

    [SerializeField] float _fallingInitialPosition;
    [SerializeField] float _floatingInitialPosition;

    private const float MIN_SPAWN_OBJECTS = -6;
    private const float MAX_SPAWN_OBJECTS = 6;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SimpleSpawn", 2, 2); // Arreglar Hardcodeo
        InvokeRepeating("SpawnCloud", 2, 4); // Arreglar Hardcodeo
        InvokeRepeating("PickUpSpawn", 5, 8); // Arreglar Hardcodeo

    }

    private void SimpleSpawn()
    {
        int randomObstacle = Random.Range(0, _obstacles.Count);
        float randomXPosition = Random.Range(MIN_SPAWN_OBJECTS, MAX_SPAWN_OBJECTS); // ARREGLAR DRY
        Vector3 spawnPosition = new Vector3(randomXPosition, _fallingInitialPosition, 10);
        Instantiate(_obstacles[randomObstacle], spawnPosition, Quaternion.identity);
    }

    private void SpawnCloud()
    {
        int randomCloud = Random.Range(0, _clouds.Count);
        float randomXPosition = Random.Range(MIN_SPAWN_OBJECTS, MAX_SPAWN_OBJECTS); // ARREGLAR DRY
        Vector3 spawnPosition = new Vector3(randomXPosition, _floatingInitialPosition, 10);
        Instantiate(_clouds[randomCloud], spawnPosition, Quaternion.identity);
    }

    private void PickUpSpawn()
    {
        float randomXPosition = Random.Range(MIN_SPAWN_OBJECTS, MAX_SPAWN_OBJECTS); // ARREGLAR DRY
        Vector3 spawnPosition = new Vector3(randomXPosition, _floatingInitialPosition, 10);
        Instantiate(_pickUpObjects[0], spawnPosition, Quaternion.identity); //Arreglar Hardcodeo
    }

}
