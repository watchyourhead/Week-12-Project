using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public MeshRenderer myRenderer;

    public float totalTime;

    public Color targetColor;

    private Color startColor;

    private float currentTime;

    private bool changeColor;

    // Update is called once per frame
    void Update()
    {
        if(changeColor)
        {
            if(currentTime < totalTime)
            {
                float percentageChange = currentTime / totalTime;
                myRenderer.material.color = Color.Lerp(startColor, targetColor, percentageChange);

                currentTime += Time.deltaTime;
            }
            else
            {
                currentTime = 0;
                changeColor = false;
            }
        }
    }

    void OnFire()
    {
        changeColor = true;
        startColor = myRenderer.material.color;
    }
}
