using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceWormSpawner : MonoBehaviour {

    public Vector2 spawnTime;
    public Vector3 offsetPosition;
    public GameObject spacewormObj;
    private float randomTime;
    private Vector3 spawnPosition;

    // Use this for initialization
    void Start () {
        spawnPosition = transform.position;
        SpawnSpaceWorm();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnSpaceWorm()
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
        Instantiate(spacewormObj, spawnPosition + offsetPosition, transform.rotation);
        Debug.Log(spawnPosition + offsetPosition);
        SpawnSpaceWorm();
    }
}
