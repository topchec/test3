using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class location : MonoBehaviour
{
    public GameObject[] roomPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        SpawnLocation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnLocation()
    {
        int randomIndex = Random.Range(0, roomPrefabs.Length);

        if (randomIndex == 0)
        {
            Vector2 spawnPosition = new Vector2(23.74f, -8.64f);
            GameObject newLocation = Instantiate(roomPrefabs[0], spawnPosition, Quaternion.identity);
                      
        }
        else if (randomIndex == 1)
        {
            Vector2 spawnPosition = new Vector2(95.5f, -54.76f);
            GameObject newLocation = Instantiate(roomPrefabs[1], spawnPosition, Quaternion.identity);
         
        }
    }
}