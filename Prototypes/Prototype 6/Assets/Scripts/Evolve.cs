using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolve : MonoBehaviour 
{
    public float transitionSpeed = 1;

    private Color s;
    
    private bool canLevel1 = true;
    private bool canLevel2 = true;
    private bool canLevel3 = true;

    [Header("Evolve Levels")]
    public int evolveLVL1;
    public int evolveLVL2;
    public int evolveLVL3;

    [Header("Color Evolve")]
    public Color evolveColorLVL1;
    public Color evolveColorLVL2;
    public Color evolveColorLVL3;


    void Update () 
	{
        Evolvee();
	}

    public void Evolvee()
    {
        float playerSize = GetComponent<PlayerConsume>().playerSize;

        if (playerSize >= evolveLVL1 && canLevel1 == true)
        {
            StartCoroutine(Level1());
        }

        if (playerSize >= evolveLVL2 && canLevel2 == true)
        {
            StartCoroutine(Level2());
        }

        if (playerSize >= evolveLVL3 && canLevel3 == true)
        {
            StartCoroutine(Level3());
        }
    }

    IEnumerator Level1()
    {
        s = GetComponent<SpriteRenderer>().color;

        GetComponent<SpriteRenderer>().color = Color.Lerp(s, evolveColorLVL1, transitionSpeed / 2 * Time.deltaTime);

        yield return new WaitForSeconds(transitionSpeed);
        canLevel1 = false;
    }

    IEnumerator Level2()
    {
        s = GetComponent<SpriteRenderer>().color;

        GetComponent<SpriteRenderer>().color = Color.Lerp(s, evolveColorLVL2, transitionSpeed * Time.deltaTime);

        yield return new WaitForSeconds(transitionSpeed);
        canLevel2 = false;
    }

    IEnumerator Level3()
    {
        s = GetComponent<SpriteRenderer>().color;

        GetComponent<SpriteRenderer>().color = Color.Lerp(s, evolveColorLVL3, transitionSpeed * Time.deltaTime);

        yield return new WaitForSeconds(transitionSpeed);
        canLevel3 = false;
    }
}
