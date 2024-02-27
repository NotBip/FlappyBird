using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour
{   
    
    public GameObject bullets; 
    public GameObject Bird; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot(); 
    }

    private void shoot() 
    {   
        Vector3 spawnPos = new Vector3(transform.position.x, Bird.transform.position.y, 0); 

        if (Input.GetMouseButtonDown(0) == true)  
            Instantiate(bullets, spawnPos, transform.rotation); 
    }
    


}
