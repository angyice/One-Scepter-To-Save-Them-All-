﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGrowth : MonoBehaviour
{
    private float maxSize = 0.01f;
    private float growFactor = 0.0005f;
    private float waitTime;

    void Start()
    { 
        StartCoroutine(Scale());
    }

    IEnumerator Scale()
    {
        float timer = 0;

        while (true)
        {
            while (maxSize > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
