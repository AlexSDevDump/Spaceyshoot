using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float moveSpeed;
    public int damage;
    public string name;
    Collider2D hitbox;

	// Use this for initialization
	void Start () {
        hitbox = GetComponent<Collider2D>();
        StartCoroutine(EnableCollision());
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D objectHit)
    {
        if (objectHit.gameObject.tag != "Destroyer")
        {
            if (objectHit.gameObject.tag == "BulletTarget")
            {
                DamageSend(objectHit);
            }
            Destroy(gameObject);
        }
    }

    void DamageSend(Collider2D objectHit)
    {
        objectHit.GetComponent<Damage>().TakeDamage(name, 10);
    }

    private IEnumerator EnableCollision()
    {
        yield return new WaitForSeconds(0.2f);
        hitbox.enabled = true;
    }
}
