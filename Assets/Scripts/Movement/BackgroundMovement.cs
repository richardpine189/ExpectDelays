using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] float _backgroundSpeed;
    private Vector2 _initialPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MakeTheBackgroundMovement();
    }

    public void ResetPosition()
    {
        transform.position = _initialPosition;
    }

    private void MakeTheBackgroundMovement()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _backgroundSpeed);
    }
}
