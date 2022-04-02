using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] float speedMovement;

    private Rigidbody _characterRb;
    private float _h;
    // Start is called before the first frame update
    void Start()
    {
        _characterRb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(_h!=0)
        {
            _characterRb.AddForce(Vector3.right * _h * speedMovement);
        }

    }
}
