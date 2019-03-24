using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormFunction : MonoBehaviour {

    public float moveSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D targetHit)
    {
        if (targetHit.gameObject.tag == "Player")
        {
            DamageSend(targetHit.gameObject);
        }
    }

    private void DamageSend(GameObject ship)
    {
        ship.GetComponent<Damage>().TakeDamage(name, 100);
        return;
    }
}
