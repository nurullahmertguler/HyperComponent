using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchChilderen : MonoBehaviour
{
    public void SearchInChilderen(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            //the desired condition is written in this if
            if (obj.CompareTag("enemy"))
            {
                if (child == transform)
                    continue;

                // functions that will run when the desired condition is reached
                //*
                    
                //*
                //***************************************************************


                return;
            }

            if (child.childCount > 0)
            {

                SearchInChilderen(child.gameObject);
            }
        }


    }
}
