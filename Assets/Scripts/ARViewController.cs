using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARViewController : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject spherePrefab;
    [SerializeField] private GameObject arCamObject;

    private int numToSpawn = 10;

    private Camera arCam;
    private Vector3 arCamPosition;

    List<GameObject> randomObjects = new List<GameObject>();

    void Start()
    {
        SpawnObject();

        arCam = GetComponentInChildren<Camera>();

    }

    void Update()
    {
        arCamPosition = arCam.transform.position;
        arCamObject.transform.SetPositionAndRotation(arCamPosition, Quaternion.identity);

    }

    void SpawnObject()
    {

        int spawned = 0;

        while (spawned < numToSpawn)
        {
            Vector3 position = new Vector3((UnityEngine.Random.Range(-1.5F, 1.5F)), 0.0F, UnityEngine.Random.Range(0.3F, 2F));
            var randomObject = Instantiate(spherePrefab, position, Quaternion.identity);
            randomObjects.Add(randomObject);
            spawned++;
        }
    }


}
