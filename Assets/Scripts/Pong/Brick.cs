using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public GameObject onCollisionEnterEffect;
    public float modifySize = 1.4f;

    public void OnTriggerEnter(Collider other)
    {
    
        Instantiate(onCollisionEnterEffect, transform.position, transform.rotation);

        // OTHER es el elemento collider, en este caso, "Ball";
        other.transform.localScale *= modifySize;
        //Character data = character.GetComponent<Character>();
        //data.score = 20;
        
        // destruyo el gameObject sobre el que está el script, osea el "Brick";
        Destroy(gameObject);
        print ("Algo explota");
    }
}