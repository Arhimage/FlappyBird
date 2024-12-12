using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 5f;

    
    private float timer = 0;
    
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        
        Vector3 spawnPos = new Vector3(transform.position.x, 
            Random.Range(lowestPoint, highestPoint), 0);
            
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
