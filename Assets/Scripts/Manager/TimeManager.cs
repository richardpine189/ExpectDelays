using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _timerText;
    public float _timerCount { get; private set; }
    private bool _isCounting = true;
    // Start is called before the first frame update
    void Start()
    {
        _timerCount = 0;
        _timerText.text += _timerCount.ToString();
        CallBackManager.onGameOver += SetTimeInPlayerPref;
    }
    private void OnDestroy()
    {
        CallBackManager.onGameOver -= SetTimeInPlayerPref;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isCounting)
        {
            _timerCount += Time.deltaTime;
            _timerText.text = $"TIME: {Mathf.Round(_timerCount)}";
        }
    }

    private void SetTimeInPlayerPref(int time)
    {
        _isCounting = false;

    }
}
