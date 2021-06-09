using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameController gameController;


    public float speed = 10;
    Vector3 velocity;
    public Character player1;
    public Character player2;

    public int player1Counter;
    public int player2Counter;

    // Awake corre una vez sola, antes de Start() ;
    void Awake()
    {
        gameController = GetComponentInParent<GameController>();
        velocity = this.transform.forward; 
        speed = 20;
    }


    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        this.transform.position += velocity * Time.deltaTime * speed;
        
    }

    // función de colisión, con qué colisiona;
    private void OnCollisionEnter(Collision collision) 
    {
        print ("La pelota chocó con : " + collision.gameObject.name); // objeto con el que colisiono;
        ContactPoint contactPoint = collision.contacts[0]; // puntos de colision, agarrá la primera posición de colisión;
        Vector3 normal = contactPoint.normal;
        velocity = 2 * (Vector3.Dot(velocity, Vector3.Normalize(normal))) * Vector3.Normalize(normal) - velocity; // puedo sacar la posición desde donde se colisiona a través de la velocidad, que también es un vector;
        velocity *= -1;
        //velocity.y = 0;
        player1.DoSomething();
        player2.DoSomething();

        if (collision.collider.gameObject.name == "Player1") {
            player1Counter+=1;
            gameController.OnScore(player1Counter);
            print ("tocó a player 1");
        } else if (collision.collider.gameObject.name == "Player2") {
            player2Counter+=1;
            gameController.OnScore(player2Counter);
            print ("tocó a player 2");
        } 
    }
}
