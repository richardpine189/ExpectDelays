using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCondition : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    [SerializeField] private GameObject _spawner;

    private bool _readyForAnimation = false;
    [SerializeField] private float _finalFallingSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        CallBackManager.onGameOver += GameOverSecuence;
    }

    private void OnDestroy()
    {
        CallBackManager.onGameOver -= GameOverSecuence;
    }

    private void Update()
    {
        if(_readyForAnimation)
        {
            _character.transform.Translate(Vector3.down * Time.deltaTime * _finalFallingSpeed);
        }
    }

    private void GameOverSecuence()
    {
        _spawner.SetActive(false);
        StartCoroutine(CharacterFalling());
    }

    IEnumerator CharacterFalling()
    {
        yield return new WaitForSeconds(1);
        _readyForAnimation = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }
}
