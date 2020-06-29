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

        arCam = GetComponentInChildren<Camera>();

        SpawnObject();

        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
    public void SpawnObject()
    {
        var index = UnityEngine.Random.Range(0, spawnObjects.Length);

        var objectToSpawn = spawnObjects[index];

        Vector3 position = new Vector3((arCam.transform.position.x + UnityEngine.Random.Range(-1.5F, 1.5F)), arCam.transform.position.y , arCam.transform.position.z + UnityEngine.Random.Range(1F, 2F));
        
        randomObject = Instantiate(objectToSpawn,position, Quaternion.identity);
    }

    void Update()
    {
        arCamObject.transform.SetPositionAndRotation(arCam.transform.position, Quaternion.identity);

        var objectPosition = randomObject.transform.position;
        
        objectPosition.y = arCam.transform.position.y;
        
        randomObject.transform.SetPositionAndRotation(objectPosition, Quaternion.identity);

        randomObject.transform.LookAt(arCam.transform.position);
    }

}
