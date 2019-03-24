using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipRotation : MonoBehaviour {

    private Quaternion DefaultRotation;
    float smooth = 10.0f;
    float tiltAngle = 20.0f;

    // Use this for initialization
    void Start ()
    {
 
	}
	
	// Update is called once per frame
	void Update ()
    {
        float tiltAroundZ = Input.GetAxis("Vertical") * tiltAngle;

        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ - 90f);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}

    /*
    public void MovementRotation(float movement)
    {
        Debug.Log("Rotate Ship");
        Debug.Log(movement);
        if (movement < 0)
        {
            transform.Rotate(0, 0, -1);
        }
        else if (movement > 0)
        {
            transform.Rotate(0, 0, 1);
        }
    }
    */
}
