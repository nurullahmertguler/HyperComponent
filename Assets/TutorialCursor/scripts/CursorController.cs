using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] GameObject clickEffectImg;
    Vector3 firstScale;
    private void Start()
    {
        Cursor.visible = false;
        firstScale = transform.localScale;
    }
    void Update()
    {
        transform.position = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            clickEffectImg.SetActive(true);
            transform.localScale = firstScale * .9f;
        }
        else
        {
            clickEffectImg.SetActive(false);
            transform.localScale = firstScale;
        }
    }
}
