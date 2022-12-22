using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SandRay();
        }
    }

    private void SandRay()
    {
        RaycastHit hit;
        float raydist = 50;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        int layerMask = 1 << 0; //it just hits the layer with the collider of object layer 8

        Debug.DrawRay(ray.origin, ray.direction * raydist, Color.blue);
        var raycast = Physics.Raycast(ray, out hit,raydist,layerMask);

        if (raycast)
        {
            if (hit.collider.tag == "Untagged")
            {
                // collect item func
                Debug.Log(hit.collider.gameObject.name);
            }

        }
    }
}
