using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject _umbrella;
    [SerializeField] private TimeManager _timeManager;
    private static int _life;
    // Start is called before the first frame update
    void Start()
    {
        _life = 3;
        CallBackManager.onUpdateDamageInUmbrella += UpdateUmbrellaAnimationState;
    }
    void OnDestroy()
    {
        CallBackManager.onUpdateDamageInUmbrella -= UpdateUmbrellaAnimationState;
    }

    private void UpdateUmbrellaAnimationState(bool isDown)
    {

        if (_life == 0)
            CallBackManager.OnGameOver((int)Mathf.Round(_timeManager._timerCount));
        if (isDown)
            _umbrella.GetComponent<Animator>().SetTrigger("DecreaseLife");
        else
            _umbrella.GetComponent<Animator>().SetTrigger("IncreaseLife");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _life--;
            CallBackManager.OnUpdateDamageInUI(true); // SACAR HARDCODEO
            CallBackManager.OnUpdateDamageInUmbrella(true);
            CallBackManager.OnChangeSpriteWhenHit();
            Destroy(other.gameObject.GetComponent<BoxCollider2D>());
        }
        else if(other.gameObject.CompareTag("PickUp"))
        {
            _life++;
            CallBackManager.OnUpdateDamageInUI(false); // SACAR HARDCODEO
            CallBackManager.OnUpdateDamageInUmbrella(false);
            Destroy(other.gameObject);
        }
    }

}
