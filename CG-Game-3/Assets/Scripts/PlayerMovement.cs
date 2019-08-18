using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	public Animator animator;

	private Vector2 movementDirection;

	public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
        movementDirection = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		rb2d.velocity = movementDirection * speed;

		Animate();

    }

	void Animate()
	{
		if (movementDirection != Vector2.zero) { 
			animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
			animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
		}

		animator.SetFloat("Speed", movementDirection.magnitude);
	}


}
