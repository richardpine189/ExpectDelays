using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeBackground : MonoBehaviour
{
    [SerializeField] Sprite[] _background;
    private void Awake()
    {
        int tempIndex = Random.Range(0, _background.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = _background[tempIndex];
    }
}
