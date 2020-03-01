using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public Vector2 spawnTime;
    public Vector3 offsetPosition;
    public GameObject objToSpawn;
    public int maxSpawns;
    private float randomTime;
    private Vector3 spawnPosition;

    // Use this for initialization
    void Start () {
        spawnPosition = transform.position;
        SpawnObject();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnObject()
    {
        spawnPosition.x += Random.Range(-5.0f, 5.0f);
        randomTime = Random.Range(spawnTime.x, spawnTime.y);
        StartCoroutine(RepeatTime());
    }

    private IEnumerator RepeatTime()
    {
        yield return new WaitForSeconds(randomTime);
        float top = Random.Range(0, 1);
        if (top < 0.5f)
            offsetPosition.y = -offsetPosition.y;
        else
            Mathf.Abs(offsetPosition.y);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length < maxSpawns)
        {
            Instantiate(objToSpawn, spawnPosition + offsetPosition, transform.rotation);
        }
        SpawnObject();
    }
}
