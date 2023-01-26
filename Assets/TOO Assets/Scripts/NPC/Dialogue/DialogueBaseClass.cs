using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
        {
             public bool finished { get; protected set; }

        protected IEnumerator WriteText(string input, Text textHolder, Font textFont, float delay, AudioClip sound, float delaybetweenLines)
                {
                     textHolder.font = textFont;
                     for (int i = 0; i < input.Length; i++)
                     {
                         textHolder.text += input[i];
                        SoundManager.instance.Playsound(sound);
                         yield return new WaitForSeconds(delay);
                     }

                    yield return new WaitUntil(() => Input.GetKey("space"));
                    finished = true;
                }
        }   

}
