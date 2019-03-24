using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public Vector2 spawnTime;
    public GameObject asteroidObj;
    private float randomAngle, randomTime;
    private Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
        spawnPosition = transform.position;
        SpawnAsteroid();
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void SpawnAsteroid()
    {
        spawnPosition.x += Random.Range(-5.0f, 5.0f); 
        randomTime = Random.Range(spawnTime.x, spawnTime.y);
        StartCoroutine(RepeatTime());
    }

    private IEnumerator RepeatTime()
    {
        yield return new WaitForSeconds(randomTime);
        Instantiate(asteroidObj, spawnPosition, transform.rotation);
        SpawnAsteroid();
    }
}
