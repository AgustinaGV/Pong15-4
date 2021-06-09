using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Vector3 dir = Vector3.left;
    public float speed = 10;
    public float limitMovement = 15;
 
    //Your Update function
    void Update(){
      transform.Translate(dir*speed*Time.deltaTime);
 
      if(transform.position.x <= -limitMovement){
           dir = Vector3.right;
      }else if(transform.position.x >= limitMovement){
           dir = Vector3.left;
      }
 }
}
