using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{   

    public float pipeMoveSpeed; 
    public GameObject topPipeHitbox; 
    public GameObject bottomPipeHitbox;
    public GameObject bullets; 
    private int deadZone = -45; 

    // Start is called before the first frame update
    void Start()
    {
        pipeMoveSpeed = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeMoveSpeed) * Time.deltaTime; 

        if (transform.position.x < deadZone) { 
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); 
        }
        
    }
}
