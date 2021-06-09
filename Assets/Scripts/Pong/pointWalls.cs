using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointWalls : MonoBehaviour
{
    // función de colisión, con qué colisiona;
    private void OnCollisionEnter(Collision collision) 
    {
        print ("La pared fue tocada por : " + collision.gameObject.name); // objeto con el que colisiono;
       

        /*if (collision.collider.gameObject.name == "Player1") {
            player1Counter+=1;
            gameController.OnScore(player1Counter);
            print ("tocó a player 1");
        } else if (collision.collider.gameObject.name == "Player2") {
            player2Counter+=1;
            gameController.OnScore(player2Counter);
            print ("tocó a player 2");
        } */
    }
}
