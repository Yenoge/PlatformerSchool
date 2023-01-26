using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool dash = false;

	//bool dashAxis = false;
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		//control input
		if (Input.GetKeyDown(KeyCode.Z))
		{
			jump = true;
		}

		if (Input.GetKeyDown(KeyCode.C))
		{
			dash = true;
		}

		if (Input.GetKey("R"))
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			
		}

		

	}
	

	//if player on floor can jump
	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	//if in air cant jump
	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		jump = false;
		dash = false;
	}
}
