using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodMaker : MonoBehaviour
{
    public float screenRelativeTransitionHeight = .03f;
    void Start()
    {
        if (GetComponent<LODGroup>() != null || GetComponent<SkinnedMeshRenderer>() != null)
            return;

        LODGroup lodGroup = gameObject.AddComponent<LODGroup>();
        var lodLevels = new LOD[1];

        Renderer[] renderers = new Renderer[1];
        
        renderers[0] = GetComponent<Renderer>();

        LOD lodlevel = new LOD(screenRelativeTransitionHeight, renderers); // screenRelativeTransitionHeight = .03f
        lodLevels[0] = lodlevel;

        lodGroup.SetLODs(lodLevels);
        
    }

    
}
