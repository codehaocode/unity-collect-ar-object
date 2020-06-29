using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARViewController : MonoBehaviour
{

    [SerializeField] private GameObject arCamObject;
    [SerializeField] public GameObject[] spawnObjects;
    
    // private int numToSpawn = 10;

    private Camera arCam;
    private Vector3 arCamPosition;
    public Vector3 randomObjectPosition;

    // List<GameObject> randomObjects = new List<GameObject>();
    public GameObject randomObject;

    void Start()
    {
        
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        SpawnObject();

        arCam = GetComponentInChildren<Camera>();

    }

    void Update()
    {
        arCamPosition = arCam.transform.position;
        arCamObject.transform.SetPositionAndRotation(arCamPosition, Quaternion.identity);

        randomObjectPosition = randomObject.transform.position;
        randomObjectPosition.y = arCamPosition.y;
        randomObject.transform.SetPositionAndRotation(randomObjectPosition, Quaternion.identity);

    }

    void SpawnObject()
    {
        // int spawned = 0;

        // while (spawned < numToSpawn)
        // {
        //     var index = UnityEngine.Random.Range(0, spawnObjects.Length);
        //     var objectToSpawn = spawnObjects[index];
        
        //     Vector3 position = new Vector3((UnityEngine.Random.Range(-1.5F, 1.5F)), 0.0F, UnityEngine.Random.Range(0.5F, 1.5F));
        //     var randomObject = Instantiate(objectToSpawn, position, Quaternion.identity);
        //     randomObjects.Add(randomObject);
        //     spawned++;
        // }
        var index = UnityEngine.Random.Range(0, spawnObjects.Length);
        var objectToSpawn = spawnObjects[index];
    
        Vector3 position = new Vector3((UnityEngine.Random.Range(-2F, 2F)), 0.0F, UnityEngine.Random.Range(1.5F, 2.5F));
        randomObject = Instantiate(objectToSpawn, position, Quaternion.identity);

    }


}
