using UnityEngine;

public class CallBackManager : MonoBehaviour
{
    public delegate void UpdateDamageInUI(bool isDown);
    public static event UpdateDamageInUI onUpdateDamageInUI;

    public delegate void UpdateDamageInUmbrella(bool isDown);
    public static event UpdateDamageInUmbrella onUpdateDamageInUmbrella;

    public delegate void UpdateSpriteWhenHit();
    public static event UpdateSpriteWhenHit onChangeSpriteWhenHit;

    public delegate void GameOverCallBack(int time);
    public static event GameOverCallBack onGameOver;
    


    public static void OnUpdateDamageInUI(bool isDown)
    {
        onUpdateDamageInUI?.Invoke(isDown);
    }

    public static void OnUpdateDamageInUmbrella(bool isDown)
    {
        onUpdateDamageInUmbrella?.Invoke(isDown);
    }

    public static void OnGameOver(int time)
    {
        onGameOver?.Invoke(time);
    }

    public static void OnChangeSpriteWhenHit()
    {
        onChangeSpriteWhenHit?.Invoke();
    }

}
