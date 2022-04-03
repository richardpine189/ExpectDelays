using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject _innerBar;
    [SerializeField] Image _umbrellaIcon; 
    [SerializeField] Color[] _barColor = new Color[4];
    [SerializeField] Sprite[] _umbrellaState = new Sprite[4];
    
    private int _count=0;

    // Start is called before the first frame update
    void Start()
    {
        CallBackManager.onUpdateDamageInUI += UpdateBar;
    }

    // Update is called once per frame
    void UpdateBar(bool isDown)
    {
        if (_count == 3) return;    
        if (isDown)
            _count++;
        else
            _count--;

        _innerBar.GetComponent<Image>().color = _barColor[_count];
        _umbrellaIcon.sprite = _umbrellaState[_count];

    }
}

public class CallBackManager : MonoBehaviour
{
    public delegate void UpdateDamageInUI(bool isDown);
    public static event UpdateDamageInUI onUpdateDamageInUI;

    public delegate void UpdateDamageInUmbrella(bool isDown);
    public static event UpdateDamageInUmbrella onUpdateDamageInUmbrella;

    public static void OnUpdateDamageInUI(bool isDown)
    {
        onUpdateDamageInUI?.Invoke(isDown);
    }

    public static void OnUpdateDamageInUmbrella(bool isDown)
    {
        onUpdateDamageInUmbrella?.Invoke(isDown);
    }
}
