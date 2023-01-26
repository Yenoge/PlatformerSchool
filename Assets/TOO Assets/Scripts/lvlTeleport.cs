using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlTeleport : MonoBehaviour
{
    public GameObject portal;

    private GameObject Player;

    public GameObject Load;

    void Start()
    {
        
        Player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(Playerstop());
            StartCoroutine(LoadScreen());
        }
    }


    IEnumerator Playerstop()
    {
        Player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        Player.GetComponent<CharacterController2D>().canMove = false;
        yield return new WaitForSeconds(1);
        Player.GetComponent<CharacterController2D>().canMove = true;
    }

    IEnumerator LoadScreen()
    {
       
        Load.SetActive(true);
        yield return new WaitForSeconds(1);
        Load.SetActive(false);
    }
}
