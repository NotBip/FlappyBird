using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe; 
    public float spawnRate = .5f; 
    public float heightOffset = 10; 
    private float timer = 0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); 
        spawnRate = 3; 
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnRate)
            timer += Time.deltaTime; 
        else {
            spawnPipe();
            timer = 0; 
        }
    }

    void spawnPipe() 
    { 
        float lowestPoint = transform.position.y - heightOffset; 
        float highestPoint = transform.position.y + heightOffset; 
        Vector3 spawnerPosY = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0); 
        
        Instantiate(pipe, spawnerPosY, transform.rotation); 
    }
}
