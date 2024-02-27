using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scoreHitbox : MonoBehaviour
{
    
    public LogicManager hitbox; 
    public BirdScript birdScript; 
    
    // Start is called before the first frame update
    void Start()
    {
        hitbox = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
        birdScript = GameObject.FindGameObjectWithTag("Birdie").GetComponent<BirdScript>(); 
    }

    /// Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    { 
        if (collision.gameObject.layer == 3 && birdScript.birdAlive)
            hitbox.addScore(1);  
    }
}
