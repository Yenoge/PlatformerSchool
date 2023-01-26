using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestructibleObject : MonoBehaviour
{
	public float life = 3;



	[Header("Sound")]
	[SerializeField] private AudioClip BreakSound;
	[SerializeField] private AudioClip HitSound;
	public AudioSource audioS;

	// The initial position of the GameObject
	Vector3 initialPosition;
	// Start is called before the first frame update

	void Awake()
	{
		initialPosition = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
		if (life <= 0)
		{
			Destroy(gameObject);
			audioS.PlayOneShot(BreakSound);
		}
	}

	public void ApplyDamage(float damage)
	{
		life -= 1;
		audioS.PlayOneShot(HitSound);
	}
}
