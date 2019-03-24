using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour
{

    public float moveSpeed;
    public float xMin, xMax, yMin, yMax;
    public GameObject sprite;

    private Vector2 moveDirection;
    private Vector2 move;
    private Vector2 clampedMovement;


    private bool inControl = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move = Vector2.zero;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        transform.Translate(move.x * moveSpeed * Time.deltaTime, move.y * moveSpeed * Time.deltaTime, 0);

        //GetScreenBorders();
        //GetLeftEdge();

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, xMin, xMax),
            Mathf.Clamp(transform.position.y, yMin, yMax)
            );

        if (move.y != 0)
        {
            //sprite.GetComponent<SpaceshipRotation>().MovementRotation(move.y);
        }
    }

    private float GetScreenBorders()
    {
        Vector3 screenDimensions = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, 0));
        return screenDimensions.x;
    }

    private float GetLeftEdge()
    {
        int left = Camera.main.pixelWidth / 2;
        return left;
    }
}
