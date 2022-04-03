using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject _umbrella;
    private static int _life = 3;
    // Start is called before the first frame update
    void Start()
    {
        //_umbrella = GameObject.Find("Umbrella"); // ARREGLAR HARDOCODEO
        CallBackManager.onUpdateDamageInUmbrella += UpdateUmbrellaAnimationState;
    }

    private void UpdateUmbrellaAnimationState(bool isDown)
    {
        if (_life == 0) return;
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
