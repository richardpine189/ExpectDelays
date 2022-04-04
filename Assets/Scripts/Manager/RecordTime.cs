using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordTime : MonoBehaviour
{
    private Dictionary<int, int> _recordTimeDictionary = new Dictionary<int, int>();
    private int _initValue = 0;

    public Dictionary<int, int> RecordTimeDictionary { get => _recordTimeDictionary; private set => _recordTimeDictionary = value; }

    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefsInstaller();
        SetFromPlayerPrefsToDictionary();
        if(SceneManager.GetActiveScene().name == "Level")
        {
            CallBackManager.onGameOver += SetTimeInRecord;
        }
    }
    private void OnDestroy()
    {
        CallBackManager.onGameOver -= SetTimeInRecord;
    }
    private void PlayerPrefsInstaller()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (!PlayerPrefs.HasKey(i.ToString()))
            {
                Debug.Log("Relleno");
                PlayerPrefs.SetInt(i.ToString(), _initValue);
            }
        }
        PlayerPrefs.Save();
    }
    public void SetFromPlayerPrefsToDictionary()
    {
        for (int i = 1; i <= 10; i++)
        {
            RecordTimeDictionary.Add(i, PlayerPrefs.GetInt(i.ToString()));
        }
    }
    
    public void SetTimeInRecord(int time)
    {
        int tempPosition = 0;
        foreach(KeyValuePair<int,int> k in RecordTimeDictionary)
        {
            if (time > k.Value)
            {
                tempPosition = k.Key;
                break;
            }
        }
        for(int i = tempPosition; i<=9;i++)
        {
            RecordTimeDictionary[i++] = RecordTimeDictionary[i];
        }
        RecordTimeDictionary[tempPosition] = time;
        SaveDictionaryInPlayerPrefs();
    }
    private void SaveDictionaryInPlayerPrefs()
    {
        foreach (KeyValuePair<int, int> k in RecordTimeDictionary)
        {
            PlayerPrefs.SetInt(k.Key.ToString(),k.Value);
        }
    }
    public Dictionary<int, int> GetDictionaryRecord()
    {
        return RecordTimeDictionary;
    }
    public void DebugDictionary()
    {
        foreach(KeyValuePair<int,int> k in RecordTimeDictionary)
        {
            Debug.Log($"Position {k.Key} has {k.Value} time.");
        }
    }

}
