using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeControl : MonoBehaviour
{
    private void OnEnable()
    {
        int episodeCount = PlayerPrefs.GetInt("episodeCount");

        if (episodeCount < 2)
            gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        
    }
}
