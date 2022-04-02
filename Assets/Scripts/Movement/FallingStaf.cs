using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStaf : MonoBehaviour
{
    [SerializeField] bool isFalling = false;
    [SerializeField] private float _initialSpeed;
    [SerializeField] private float _currentSpeed;
    [SerializeField] private float _rotationSpeed;

    private Transform _stafTransform;
    private Vector2 fallingVector;

    // Start is called before the first frame update
    void Start()
    {
        _stafTransform = gameObject.GetComponent<Transform>();
        
        fallingVector = isFalling ? Vector2.down : Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        _stafTransform.Translate(fallingVector * _initialSpeed * Time.deltaTime, Space.World);
        _stafTransform.Rotate(Vector3.forward * Time.deltaTime * _rotationSpeed);
    }
}
