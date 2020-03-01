using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipController : MonoBehaviour {

    public float moveSpeed, xPlane, yMin, yMax;
    public GameObject sprite;
    private bool up;
    private int upF;

    // Use this for initialization
    void Start ()
    {
        up = true;
        FlyForward();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x > xPlane)
        {
            FlyForward();
        }
        else
        {
            Strafe();
        }
    }

    private void FlyForward()
    {
        transform.Translate(-1f * moveSpeed * Time.deltaTime, 0, 0);
    }

    private void Strafe()
    {
        if (up == true)
        {
            upF = 1;
        }
        else
        {
            upF = -1;
        }
        transform.Translate(0, upF * moveSpeed * Time.deltaTime, 0);
        CheckBorder();
    }

    private void CheckBorder()
    {
        if (transform.position.y >= yMax)
        {
            up = false;
        }
        if (transform.position.y <= yMin)
        {
            up = true;
        }
    }
}
