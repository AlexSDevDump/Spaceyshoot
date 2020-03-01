using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private float distanceTravelled;
    private float finalDistance;
    public Text distanceText;
    public Text deathText;
    private bool dead;

	// Use this for initialization
	void Start () {
        deathText.gameObject.SetActive(false);
        dead = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (dead == false)
        {
            distanceTravelled += 10 * Time.deltaTime;
            distanceText.text = "Distance Travelled: " + distanceTravelled.ToString("F2");
        }
	}

    public void EndGame()
    {
        dead = true;
        finalDistance = distanceTravelled;
        Debug.Log("You survived " + finalDistance + " metres");
        deathText.text = "You Travelled " + finalDistance.ToString("F2") + " metres";
        distanceText.gameObject.SetActive(false);
        deathText.gameObject.SetActive(true);
    }
}
