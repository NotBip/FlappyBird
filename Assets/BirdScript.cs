using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{   
    public GameObject pipeSpawner; 
    public Rigidbody2D myRigidBody; 
    private float jumpVelocity = 14.88f; 
    public LogicManager logic; 
    public bool birdAlive = true; 


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
    }

    // Update is called once per frame
    void Update()
    {     
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
            myRigidBody.velocity = Vector2.up * jumpVelocity; 

        if (myRigidBody.transform.position.y <= -16 || myRigidBody.transform.position.y >= 16)
            endGame(); 


            
    }
    
    private void OnCollisionEnter2D(Collision2D collision) 
    {   
            endGame(); 
    }

    private void endGame() 
    { 
        pipeSpawner.SetActive(false); 
        pipeSpawner.GetComponent<PipeSpawnerScript>().CancelInvoke(); 
        logic.gameOver(); 
        birdAlive = false; 
    }
}
