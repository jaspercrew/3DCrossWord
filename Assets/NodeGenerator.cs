using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGenerator : MonoBehaviour
{
    public GameObject nodePrefab;

    public const int size = 5;
    // Start is called before the first frame update
    void Start()
    {
        GenerateNodes();
    }

    void GenerateNodes()
    {
        Vector3 spawnPosition = Vector3.zero;
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                for (int k = 0; k < size; k++)
                {
                    Instantiate(nodePrefab, spawnPosition, Quaternion.identity, transform);
                    spawnPosition += Vector3.right; 
                }
                spawnPosition += Vector3.up;
                spawnPosition = new Vector3(0, spawnPosition.y, spawnPosition.z);
            }
            spawnPosition += Vector3.forward;
            spawnPosition = new Vector3(spawnPosition.x, 0, spawnPosition.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
