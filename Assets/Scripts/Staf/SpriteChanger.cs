using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite _nextSprite;
    private Sprite _tempSprite;
    // Start is called before the first frame update
    void Start()
    {
        CallBackManager.onChangeSpriteWhenHit += ChangeTheSpriteWhenHit;
    }

    private void OnDestroy()
    {
        CallBackManager.onChangeSpriteWhenHit -= ChangeTheSpriteWhenHit;
    }

    private  void ChangeTheSpriteWhenHit()
    {
        if (gameObject.name == "Character")
        {
            gameObject.GetComponent<Animator>().SetTrigger("CharacterIsHit");
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = _nextSprite;
    }
    
}
