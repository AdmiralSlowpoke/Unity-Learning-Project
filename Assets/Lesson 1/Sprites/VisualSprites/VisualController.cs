using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slide[] slides;
    public Text text,name;
    private int slideInt=0;
    void Start()
    {
        if(slides.Length>0)
        ChangeSlide(slides[slideInt]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (slides.Length - 1 > slideInt)
            {
                slideInt++;
                ChangeSlide(slides[slideInt]);
            }
        }
    }
    private void ChangeSlide(Slide slide)
    {
        text.text = slide.text;
        name.text = slide.character.name;
        name.color = slide.character.colorName;
        slide.character.ChangeEmotion(slide.emotion);
    }
}
[Serializable]
public class Slide
{
    public CharacterVisual character;
    public CharacterVisual.CharacterEmotion emotion;
    public string text;
}
