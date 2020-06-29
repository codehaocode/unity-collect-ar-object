using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject[] spawnObjects;

    public GameObject SpawnObject()
    {
        var index = UnityEngine.Random.Range(0, spawnObjects.Length);
        var objectToSpawn = spawnObjects[index];
    
        Vector3 position = new Vector3((UnityEngine.Random.Range(-2F, 2F)), 0.0F, UnityEngine.Random.Range(1.5F, 2.5F));
        return Instantiate(objectToSpawn, position, Quaternion.identity);
    }

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
    }

}
