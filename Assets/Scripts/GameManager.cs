using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject[] spawnObjects;
    [SerializeField] private GameObject arCamObject;
    private Camera arCam;
    private Vector3 arCamPosition;
    private Vector3 objectPosition;
    private GameObject randomObject;
    public static GameManager Instance {
        get {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                
                if (instance == null)
                {
                    var go = new GameObject();
                    instance = go.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }
    private static GameManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        SpawnObject();

        arCam = GetComponentInChildren<Camera>();

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    void Update()
    {
        arCamPosition = arCam.transform.position;

        arCamObject.transform.SetPositionAndRotation(arCamPosition, Quaternion.identity);

        objectPosition = randomObject.transform.position;
        
        objectPosition.y = arCamPosition.y;
        
        randomObject.transform.SetPositionAndRotation(objectPosition, Quaternion.identity);
    }

    public void SpawnObject()
    {
        var index = UnityEngine.Random.Range(0, spawnObjects.Length);

        var objectToSpawn = spawnObjects[index];

        Vector3 position = new Vector3((UnityEngine.Random.Range(-2F, 2F)), 0.0F, UnityEngine.Random.Range(1.5F, 2.5F));
        
        randomObject = Instantiate(objectToSpawn, position, Quaternion.identity);
    }

}
