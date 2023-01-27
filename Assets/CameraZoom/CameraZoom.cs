using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraZoom : MonoBehaviour
{
    Camera m_Camera;
    [SerializeField] float sensitivity=1;

    private void Awake()
    {
        m_Camera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            MakeZoom(difference * -1);
        }
        else if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            MakeZoom(Input.GetAxis("Mouse ScrollWheel") * sensitivity * -1 / Time.deltaTime);
        }
        

        
    }
    [Space(10)]
    [SerializeField] float minZoom,maxZoom;
    void MakeZoom(float difference)
    {
        float camSize = m_Camera.orthographicSize;
        camSize += difference * Time.deltaTime * sensitivity * Time.deltaTime;
        m_Camera.orthographicSize = Mathf.Clamp(camSize, minZoom, maxZoom);
    }
}
