using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public float score;
    public GameObject scoreText;

    void Start ()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText");
    }
	

	void Update ()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
