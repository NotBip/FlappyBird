using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullets : MonoBehaviour
{   
    private float bulletMoveSpeed = 30f; 
    private float lifeTime = 2; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = transform.position + (Vector3.right * bulletMoveSpeed) * Time.deltaTime; 
        Destroy(gameObject, lifeTime);
    }


    private void OnCollisionEnter2D(Collision2D collision) 
    {   
        Destroy(gameObject);
    }

}
