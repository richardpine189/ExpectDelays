using UnityEngine;

public class CallBackManager : MonoBehaviour
{
    public delegate void UpdateDamageInUI(bool isDown);
    public static event UpdateDamageInUI onUpdateDamageInUI;

    public delegate void UpdateDamageInUmbrella(bool isDown);
    public static event UpdateDamageInUmbrella onUpdateDamageInUmbrella;

    public delegate void GameOverCallBack();
    public static event GameOverCallBack onGameOver;


    public static void OnUpdateDamageInUI(bool isDown)
    {
        onUpdateDamageInUI?.Invoke(isDown);
    }

    public static void OnUpdateDamageInUmbrella(bool isDown)
    {
        onUpdateDamageInUmbrella?.Invoke(isDown);
    }

    public static void OnGameOver()
    {
        onGameOver?.Invoke();
    }
}
