using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    float duration = 1;
    [SerializeField] float force = 1;



    public static Action<float> CameraShake;

    private void OnEnable() => CameraShake += Shaker;

    private void OnDisable() => CameraShake -= Shaker;
    

    public void Shaker(float durationTime = 1)
    {
        duration = durationTime;
        StartCoroutine(CameraShakeCr());
    }

    IEnumerator CameraShakeCr()
    {
        Vector3 startPos = transform.position;

        float elapsedTime=0;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration) * force;
            transform.position = startPos + Random.insideUnitSphere * strength;
            yield return null;
        }
        transform.position = startPos;
    }
}
