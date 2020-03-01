using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float moveSpeed;
    public int damage;
    public string name;
    public Rigidbody2D rb;
    Collider2D hitbox;

	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * moveSpeed;
    }


    private void OnTriggerEnter2D(Collider2D objectHit)
    {
        Debug.Log(objectHit);
        if (objectHit.gameObject.tag != "Destroyer")
        {
            Damage enemy = objectHit.GetComponent<Damage>();

            if (enemy != null)
            {
                Debug.Log(enemy.name);
                objectHit.GetComponent<Damage>().TakeDamage(name, 10);
            }
            Destroy(gameObject);
        }
    }
}
