using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Sprite triggered;
    public GameObject obstacle;

    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void turnOn()
    {
        _spriteRenderer.sprite = triggered;

        obstacle.GetComponent<Obstacle>().destroy();


        gameObject.layer = LayerMask.NameToLayer("Decoration");
    }
}
