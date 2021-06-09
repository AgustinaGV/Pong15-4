using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreField;
    int score = 0;

    void Start()
    {

        scoreField.text = "0";
        
    }

    public void OnScore (int hitsCounter) {
        score += hitsCounter;
        scoreField.text = hitsCounter.ToString();
    }
}
