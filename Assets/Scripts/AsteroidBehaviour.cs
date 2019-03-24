using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    public float moveSpeed;
    public string name;


    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D targetHit)
    {
        if (targetHit.gameObject.tag == "Player")
        {
            DamageSend(targetHit.gameObject);
        }

        if (targetHit.gameObject.tag != "Destroyer")
        {
            //DestroySelf();
        }
    }

    private void DamageSend(GameObject hitObject)
    {
        hitObject.GetComponent<Damage>().TakeDamage(name, 10);
        return;
    }

    private void DestroySelf()
    {
        Debug.Log("Destroy self");
        Destroy(gameObject);
    }
}
