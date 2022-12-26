using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTest : MonoBehaviour
{
    public float duration;

    private void Start()
    {
        //Application.targetFrameRate = 999;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CameraShaker.CameraShake(duration);
        }
    }
}
