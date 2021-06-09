using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Transform targetFollow; //objeto al que sigo;
    public Transform targetView;
    public float speed;
    public float smooth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetFPosition = targetFollow.position;
        Vector3 targetVPosition = targetView.position;
        float dest = targetFPosition.x;
        // transform.position --> posición de MyCamera;
        //targetFPosition --> posición del objeto que se sigue;
       /* transform.position = new Vector3(Mathf.Lerp(transform.position.x, dest, smooth * Time.deltaTime), transform.position.y, transform.position.z);
        transform.LookAt(targetVPosition);*/
        
    }
}
