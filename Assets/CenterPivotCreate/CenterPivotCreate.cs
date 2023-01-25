using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPivotCreate : MonoBehaviour
{
    void Start()
    {
        
    }

    private void Init()
    {
        var mesh = GetComponent<MeshFilter>().sharedMesh;

        Vector3 pivotPos = Vector3.zero;

        foreach (var item in mesh.vertices)
        {
            pivotPos += item;
        }

        pivotPos = pivotPos / mesh.vertices.Length;

        Debug.Log(pivotPos);

        GameObject center = new GameObject();
        center.transform.SetParent(transform);
        center.transform.SetLocalPositionAndRotation(Vector3.zero, new Quaternion(0, 0, 0, 0));
        center.transform.localScale = Vector3.one;

        center.transform.localPosition = pivotPos;
    }
}
