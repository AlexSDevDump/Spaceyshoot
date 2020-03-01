using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public int health, shield;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            if(gameObject.tag == "Player")
            {
                Die();
            }
        }
    }

    public void TakeDamage(string enemy, int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Player")
        {
            Debug.Log("Player DIED");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

