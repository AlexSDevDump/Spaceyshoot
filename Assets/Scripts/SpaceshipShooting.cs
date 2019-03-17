using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour {

    public GameObject bulletObj, gunBarrelLeftObj, gunBarrelRightObj;
    public float fireRate;
    private bool gunReady, gunLeft;
    private GameObject gunBarrelObj;
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
        if (Input.GetButton("Fire1") && gunReady == true)
        {
            gunReady = false;
            if (gunLeft == true) { gunBarrelObj = gunBarrelLeftObj; }
            else { gunBarrelObj = gunBarrelRightObj; }
            Instantiate(bulletObj, gunBarrelObj.transform.position, gunBarrelObj.transform.rotation);
            gunLeft = !gunLeft;
            StartCoroutine(FireGun());
        }


	}

    IEnumerator FireGun()
    {
        yield return new WaitForSeconds(fireRate);
        gunReady = true;

    }
}
