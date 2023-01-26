using UnityEngine;



public static class LayerSetAllChilderens
{
    public static void UpdateLayer(GameObject obj, int layerNumb)
    {
        obj.layer = layerNumb;
        foreach (Transform child in obj.transform)
        {
            child.gameObject.layer = layerNumb;

            if (child.childCount > 0)
            {
                UpdateLayer(child.gameObject, layerNumb);
            }
        }
    }
}
