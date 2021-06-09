using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public UIManager uiManager;

    public void OnScore(int score)
    {
       uiManager.OnScore(score);
    }
}
