using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARViewController : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject spherePrefab;

    private ARPlaneManager arPlaneManager;

    private int numToSpawn = 10;

    void Awake()
    {

    }


    void Start()
    {
        SpawnObject();


    }

    void Update()
    {
     
    }

    void SpawnObject()
    {

        int spawned = 0;

        while (spawned < numToSpawn)
        {
            Vector3 position = new Vector3((UnityEngine.Random.Range(-1F, 1F)), 0.0F, UnityEngine.Random.Range(0.1F, 1.5F));
            GameObject randomObject = Instantiate(spherePrefab, position, Quaternion.identity);
            spawned++;
        }
    }

}
