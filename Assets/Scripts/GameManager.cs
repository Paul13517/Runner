using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public Text scoreText;
    
    private void Awake ()
    {
        inst = this;
    }
    // Start is called before the first frame update
    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
