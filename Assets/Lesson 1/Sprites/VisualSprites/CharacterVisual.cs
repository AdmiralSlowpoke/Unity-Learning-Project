using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterVisual : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public Color32 colorName;
    public enum CharacterEmotion {Normal,Talk,Laugh,Scared};
    public Sprite normalSprite, talkSprite, laughSprite, scaredSprite;
    private Image characterImage;
    void Awake()
    {
        characterImage = gameObject.GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeEmotion(CharacterEmotion emotion)
    {
        switch (emotion)
        {
            case CharacterEmotion.Normal:
                characterImage.sprite = normalSprite;
                break;
            case CharacterEmotion.Talk:
                characterImage.sprite = talkSprite;
                break;
            case CharacterEmotion.Laugh:
                characterImage.sprite = laughSprite;
                break;
            case CharacterEmotion.Scared:
                characterImage.sprite = scaredSprite;
                break;
            default:
                break;
        }
    }
}
