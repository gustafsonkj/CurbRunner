using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurbSpawner : MonoBehaviour {

    public GameObject curb;
    public Vector3 spawnPosition;
    
	void Start ()
    {
        
    }
	
	void Update ()
    {
        spawnPosition = new Vector3(spawnPosition.x + 20f, spawnPosition.y, spawnPosition.z);
        Instantiate(curb, spawnPosition, Quaternion.identity);
	}
}
