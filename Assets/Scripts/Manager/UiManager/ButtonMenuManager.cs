using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenuManager : MonoBehaviour
{

    [SerializeField] GameObject _creditPanel;
    [SerializeField] GameObject _recordPanel;

    public void OnLoadLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void OnExit()
    {
        Application.Quit();
    }
    public void OnLoadCreditPanel()
    {
        _creditPanel.SetActive(true);
    }
    public void OnUnloadCreditPanel()
    {
        _creditPanel.SetActive(false);
    }
    public void OnLoadRecordPanel()
    {
        _recordPanel.SetActive(true);
    }
    public void OnUnloadRecordPanel()
    {
        _recordPanel.SetActive(false);
    }
    public void OnLoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
