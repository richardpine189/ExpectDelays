using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStaf : MonoBehaviour
{
    [SerializeField] bool isFalling = false;
    [SerializeField] bool isRotating = false;
    [SerializeField] bool controlSpeed = false;
    [SerializeField] private float _initialSpeed;
    [SerializeField] private float _currentSpeed;
    [SerializeField] private float _rotationSpeed;

    private const float MIN_ROTATION_SPEED = -30;
    private const float MAX_ROTATION_SPEED = 30;
    private const float MIN_FALLING_SPEED = 0;
    private const float MAX_FALLING_SPEED = 30;
    private Transform _stafTransform;
    private Vector2 fallingVector;

    // Start is called before the first frame update
    void Start()
    {
        _stafTransform = gameObject.GetComponent<Transform>();
        
        fallingVector = isFalling ? Vector2.down : Vector2.up;

        RandomizeSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        _stafTransform.Translate(fallingVector * _initialSpeed * Time.deltaTime, Space.World);
        if(isRotating)
        _stafTransform.Rotate(Vector3.forward * Time.deltaTime * _rotationSpeed);
    }

    void RandomizeSpeed()
    {
        if(!controlSpeed) 
            _initialSpeed = Random.Range(MIN_FALLING_SPEED, MAX_FALLING_SPEED);
        if(isRotating)
            _rotationSpeed = Random.Range(MIN_ROTATION_SPEED, MAX_ROTATION_SPEED);
    }
}


