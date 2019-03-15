using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour {

    public float moveSpeed;

    private Vector2 moveDirection;
    private Vector2 move;
    private Rigidbody2D rb2d;

    private bool inControl = true;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        move = Vector2.zero;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        moveDirection = (transform.up * move.y + transform.right * move.x);
        moveDirection = moveDirection.normalized * moveSpeed;
	}

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveDirection * Time.fixedDeltaTime);
    }
}
