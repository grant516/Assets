using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorPlacer : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject DoorPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(DoorPrefabs, spawnPoints[i].position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
