using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FillRecordTable : MonoBehaviour
{
    [SerializeField] private RecordTime _recordTime;
    [SerializeField] private GameObject _parentContainer;
    [SerializeField] private GameObject _recordPrefab;

    private Dictionary<int, int> _record = new Dictionary<int, int>();

    // Start is called before the first frame update
    void Start()
    {
        _record = _recordTime.GetDictionaryRecord();
        InitRecord();
    }
    private void InitRecord()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject tempGo = Instantiate(_recordPrefab, _parentContainer.transform);
            tempGo.GetComponent<TextMeshProUGUI>().text = $"{1} - Position : {_record[i]}";
        }
    }
}
