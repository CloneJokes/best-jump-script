using UnityEngine;
using System.Collections;

publick class Jump : MonoBehaviour {
	
	[Range(1, 20)]
	public float jumpVelocity;
	public float augmentFall = 2.5f;
	public float augmentLowJump = 2f;

	Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	void Update(){
		//press jump to jump
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
		}

		//tap and hold jump button changes jump distance and also speeds downfall
		if(rb.velocity.y < 0){
			rb.velocity += Vector2.up * Physics2D,gravity.y * (augmentFall - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")){
			rb.velocity += Vector2.up * Physics2D.gravity.y * (augmentLowJump - 1) * Time.deltaTime;
		}
	}
}
//you can test this by creating a square game object, and make a platform out of that object, and give it a box collider 2d, rigid body2d and attack the script to the player. don't forget to give the platform a collider to interact with the game object.