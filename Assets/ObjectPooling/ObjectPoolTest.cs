using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(0);
        obj.transform.position = transform.position;
        StartCoroutine(SetPool(obj));
    }

    IEnumerator SetPool(GameObject obj)
    {
        yield return new WaitForSeconds(3);
        ObjectPool.Instance.SetBooledObject(obj);
    }
}
