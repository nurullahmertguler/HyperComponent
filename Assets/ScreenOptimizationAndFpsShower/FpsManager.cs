using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FpsManager : MonoBehaviour
{
    [Space(10)]
    public TextMeshProUGUI text;

    [Space(5)]
    public int targetFrame;

    [Space(10)]
    [Header("screen quality loss       Min:%0      Max:%15")]
    public float qualityLossRate=10;

    float deltaTime = 0.0f;

    private void Start()
    {
        // limited so that the game quality does not deteriorate too much
        qualityLossRate = Mathf.Clamp(qualityLossRate,0,15);

        // target fps value assignment of the game
        Application.targetFrameRate = targetFrame;


        float sc = 1 + (qualityLossRate / 100);
        sc = Mathf.Clamp(sc ,1 ,1.2f);
        Screen.SetResolution((int)(Screen.width / sc), (int)(Screen.height / sc) , false);
    }
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        text.text = string.Format("{0:0.0} ms \n({1:0.} fps)", msec, fps);
    }
}