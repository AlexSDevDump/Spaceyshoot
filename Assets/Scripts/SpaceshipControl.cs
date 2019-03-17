using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour {

    public float moveSpeed;
    public float xMin, xMax, yMin, yMax;

    private Vector2 moveDirection;
    private Vector2 move;
    private Vector2 clampedMovement;


    private bool inControl = true;

   

	// Use this for initialization
	void Start ()
    {

	}

	// Update is called once per frame
	void Update ()
    {
        move = Vector2.zero;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        transform.Translate(move.x * moveSpeed * Time.deltaTime, move.y * moveSpeed * Time.deltaTime, 0);

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, xMin, xMax),
            Mathf.Clamp(transform.position.y, yMin, yMax)
            );
    }
}
