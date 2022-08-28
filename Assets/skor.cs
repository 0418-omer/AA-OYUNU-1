using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Text scoretext;
    public int score ;
    // skor verme ve arttırma işlemi
    private void Start()
    {
        score=0;
    }

 public void UpdateScore()
    {

        score++;
        scoretext.text=score.ToString();

    }   
}
