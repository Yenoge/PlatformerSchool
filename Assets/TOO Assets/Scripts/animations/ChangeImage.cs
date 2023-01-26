using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    //add the images you want to swap in the publics <3
    //then add it to a button or image with pointclick <3
    
    public Image oldImage;
    public Sprite newImage;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageChange()
    {
        oldImage.sprite = newImage;
    }
}
