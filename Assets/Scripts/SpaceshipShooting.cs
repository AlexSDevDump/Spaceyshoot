using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour {

    public GameObject bulletObj; 
    public Transform gunBarrelLeftObj, gunBarrelRightObj;
    public float fireDelay;
    private bool gunReady, gunLeft;
    private Transform gunBarrelObj;
	// Use this for initialization
	void Start ()
    {
        gunReady = true;
        gunLeft = true;
        gunBarrelObj = gunBarrelLeftObj;
	}

    // Update is called once per frame
    void Update()
    {
        if (gunReady == true)
        {
            gunReady = false;
            if (gunLeft == true) { gunBarrelObj = gunBarrelLeftObj; }
            else { gunBarrelObj = gunBarrelRightObj; }
            Instantiate(bulletObj, gunBarrelObj.position, gunBarrelObj.rotation);
            gunLeft = !gunLeft;
            StartCoroutine(FireGun());
        }
	}

    IEnumerator FireGun()
    {
        yield return new WaitForSeconds(fireDelay);
        gunReady = true;

    }
}
