// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR.ARFoundation;

// public class ARViewController : MonoBehaviour
// {
//     [SerializeField] private GameObject arCamObject;
//     private Camera arCam;
//     private Vector3 arCamPosition;
//     public Vector3 objectPosition;
//     public GameObject randomObject;

//     void Start()
//     {
//         Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
//         randomObject = GameManager.Instance.SpawnObject();

//         arCam = GetComponentInChildren<Camera>();
//     }

//     void Update()
//     {
//         arCamPosition = arCam.transform.position;
//         arCamObject.transform.SetPositionAndRotation(arCamPosition, Quaternion.identity);

//         objectPosition = randomObject.transform.position;
//         objectPosition.y = arCamPosition.y;
//         randomObject.transform.SetPositionAndRotation(objectPosition, Quaternion.identity);
//     }



// }
