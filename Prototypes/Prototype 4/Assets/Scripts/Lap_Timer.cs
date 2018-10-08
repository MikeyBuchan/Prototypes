using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lap_Timer : MonoBehaviour 
{
    public GameObject finishLine;

    [Header("Lap Count")]
    public Text lapCount;
    public int lapCounter;

    [Header("Lap Timer")]
    public Text lapTime;
    public float lapTimer;
    public List<float> lapTimes;

    [Header("Total Timer")]
    public Text totalTime;
    public float totalTimer;

    [Header("Finish Line")]
    public GameObject finishLinePanel;

    public Text totalTime1;

    public Text lap1;
    public Text lap2;
    public Text lap3;


    void Start()
    {
        lapCounter = 1;
    }

    void Update () 
	{
        LapTimer();
        TotalTimer();
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.transform.tag == "FinishLine")
        {
            print("Finished lap");

            if (lapCounter == 1)
            {
                lap1.text = ("Lap 1: ") + lapTimer.ToString();
            }

            if (lapCounter == 2)
            {
                lap2.text = ("Lap 2: ") + lapTimer.ToString();
            }

            if (lapCounter == 3)
            {
                lap3.text = ("Lap 3: ") + lapTimer.ToString();
            }

            lapCounter += 1;
            lapCount.text = ("LAP ") + lapCounter + ("/3").ToString();

            lapTimes.Add(lapTimer);

            lapTimer = 0f;

            if (lapCounter == 4)
            {
                finishLinePanel.SetActive(true);
                lapCounter = 3;
                totalTime1.text = totalTimer.ToString();
                Time.timeScale = 0;
            }
        }
    }

    void LapTimer()
    {
        lapTimer += Time.deltaTime;
        lapTimer = Mathf.Round(lapTimer * 1000f) / 1000f;
        lapTime.text = lapTimer.ToString("0.000");
    }

    void TotalTimer()
    {
        totalTimer += Time.deltaTime;
        totalTimer = Mathf.Round(totalTimer * 1000f) / 1000f;
        totalTime.text = totalTimer.ToString("0.000");
    }
}
