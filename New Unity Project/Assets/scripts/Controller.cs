using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public float speed;
	public float gravity;
	public float jumpHeight;
	public LayerMask Ground;
	public Transform feet;
	public GameObject gameOverPanel;

	private Vector3 direction;
	private Vector3 walkingVelocity;
	private Vector3 fallingVelocity;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		gameOverPanel.SetActive (false);
		speed = 5.0f;
		gravity = 9.8f;
		jumpHeight = 3.0f;
		direction = Vector3.zero;
		fallingVelocity = Vector3.zero;
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		direction.x = Input.GetAxis("Horizontal");
		direction.z = Input.GetAxis("Vertical");
		direction = direction.normalized;
		walkingVelocity = direction * speed;
		controller.Move(walkingVelocity * Time.deltaTime);

		bool isGrounded = Physics.CheckSphere(feet.position, 0.1f, Ground, QueryTriggerInteraction.Ignore);
		if(isGrounded)
			fallingVelocity.y = 0f;
		else
			fallingVelocity.y -= gravity * Time.deltaTime;
		if(Input.GetButtonDown("Jump") && isGrounded) {
			fallingVelocity.y = Mathf.Sqrt(gravity * jumpHeight);
		}
		controller.Move(fallingVelocity * Time.deltaTime);
	}
}
