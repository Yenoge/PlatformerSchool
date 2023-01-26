using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textholder;

        [Header ("font 0")]
        [SerializeField] private string input;
        [SerializeField] private Font textFont;

        [Header("Time parameter")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header("Sound")]
        [SerializeField] private AudioClip sound;

        [Header("Character Image")]
        [SerializeField] private Sprite ChracterSprite;
        [SerializeField] private Image imageHolder;

        private IEnumerator lineAppear;

        private void Awake()
        {
            textholder = GetComponent<Text>();
            textholder.text = "";

            
            imageHolder.sprite = ChracterSprite;
            imageHolder.preserveAspect = true;
        }

        private void OnEnable()
        {
            ResetLine();
            lineAppear = (WriteText(input, textholder, textFont, delay, sound, delayBetweenLines));
            StartCoroutine(lineAppear);
        }
        private void Update()
        {
            if (Input.GetKey("x"))
            {
                if (textholder.text != input)
                {
                    StopCoroutine(lineAppear);
                    textholder.text = input;
                }    
                else
                    finished = true;
            }
        }

        private void ResetLine()
        {
            textholder = GetComponent<Text>();
            textholder.text = "";
            finished = false;
        }
    }
}


