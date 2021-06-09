 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    // con PUBLIC establezco una velocidad "estandar", es la base. Desde la interfaz de Unity genero instancias donde asigno el valor final, de esta manera puedo tener los mismos objetos con los mismos scripts, pero con distintos valores;
    public float speed = 10;
    public Vector3 currentPosition;
    public float smooth;
    public Character character;

    public KeyCode MoveUp;
    public KeyCode MoveDown;
    public KeyCode MoveRight;
    public KeyCode MoveLeft;

    GameController gameController;

    public float score = 0f;

    void Awake()
    {
        gameController = GetComponentInParent<GameController>();
    }

    void Update()
    {
        currentPosition = transform.position;
        if (Input.GetKey(MoveRight)) {
            // cada frame mientras se apriete D;
            print ("apretaste derecha");
            // modifica posicion hacia la derecha;
            //Vector3 temp = new Vector3(0.5f, 0, 0);
            if (currentPosition.x < 20f) {
                //this.transform.position += temp;
                transform.Translate(Vector3.right * speed * (smooth * Time.deltaTime));
                // Time.deltaTime de alguna forma estandariza la velocidad en relacion al procesamiento en distintas computadoras;
            }
            

        } else if (Input.GetKey(MoveLeft)) {
            print ("apretaste izquierda");
            // modifica posicion hacia la derecha;
            //Vector3 temp = new Vector3(-0.5f, 0, 0);
            if (currentPosition.x > -20f) {
                //this.transform.position += temp;
                transform.Translate(Vector3.left * speed * (smooth * Time.deltaTime));
            }

        } else if (Input.GetKey(MoveUp)) {
            print ("apretaste arriba");
            // modifica posicion hacia la derecha;
            //Vector3 temp = new Vector3(-0.5f, 0, 0);
            if (currentPosition.y > -20f) {
                //this.transform.position += temp;
                transform.Translate(Vector3.up * speed * (smooth * Time.deltaTime));
            }

        } else if (Input.GetKey(MoveDown)) {
            print ("apretaste abajo");
            // modifica posicion hacia la derecha;
            //Vector3 temp = new Vector3(-0.5f, 0, 0);
            if (currentPosition.y > -20f) {
                //this.transform.position += temp;
                transform.Translate(Vector3.down * speed * (smooth * Time.deltaTime));
            }

        }
    }
    private void OnCollisionEnter (Collision collision) {
        print ("El pituto chocó con: " + collision.gameObject.name);
    }

    public void DoSomething () {
        print ("Character hace algo!");
    }
}
