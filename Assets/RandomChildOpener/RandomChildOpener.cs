using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChildOpener : MonoBehaviour
{
    private void OnEnable()
    {
        int totalChild = transform.childCount;

        int r = Random.Range(0,totalChild);

        foreach (Transform item in transform)
        {
            item.gameObject.SetActive(false);
        }

        transform.GetChild(r).gameObject.SetActive(true);
    }
}
