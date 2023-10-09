//using Sirenix.OdinInspector;
//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using System;
//using DG.Tweening;

//#if UNITY_EDITOR // Editor namespaces can only be used in the editor.
//using Sirenix.OdinInspector.Editor.Examples;
//#endif

//public class GridSystem : SerializedMonoBehaviour
//{
    
//    // MATRIX
//    [TableMatrix(HorizontalTitle = "Grid Matrix", SquareCells = true)]
//    public GameObject[,] GridMatrix = new GameObject[6,8];


//    [SerializeField] float gridPadd = .75f;
    

//    private void Start()
//    {

//    }

    

    
//    public Vector3 GridPosCalculator(int gridx , int gridy)
//    {
//        float startxPos = (3 * gridPadd * -1) + gridPadd / 2;
//        float posx = startxPos + (gridx * gridPadd);

//        float startyPos = transform.position.y;
//        float posy = startyPos + (gridy * gridPadd * -1);

//        return new Vector3(posx , posy , 0);
//    }

//    //public void EmptyGridControl()
//    //{
//    //    List<GridObj> objList = new List<GridObj>();

//    //    for (int i = 0; i < 6; i++)
//    //    {
//    //        for (int j = 0; j < 8; j++)
//    //        {
//    //            if (GridMatrix[i, j] == null)
//    //            {
//    //                GridObj gridObject = new GridObj();
//    //                gridObject.obj = GridMatrix[i, j];
//    //                gridObject.gridX = i;
//    //                gridObject.gridY = j;
//    //                gridObject.gridPos = GridPosCalculator(i, j);

//    //                objList.Add(gridObject);
//    //            }
//    //        }
//    //    }
//    //    if (objList.Count == 0)
//    //        ResourceSystem.ThisGridEmptyAction(null);
//    //    else
//    //        ResourceSystem.ThisGridEmptyAction(objList[UnityEngine.Random.Range(0, objList.Count)]);
//    //}

//    //public void ResourcesAddToGrid(GridObj gridObject)
//    //{
//    //    GridMatrix[gridObject.gridX, gridObject.gridY] = gridObject.obj;

//    //    gridObject.obj.GetComponent<Resource>().gridObject = gridObject;
//    //}


//    //public void SnapControl(GridObj gridObject , Vector3 dragGridPos)
//    //{
//    //    GridObj nearestGrid = new GridObj();
//    //    nearestGrid.gridX = 0;
//    //    nearestGrid.gridY = 0;

//    //    for (int i = 0; i < 6; i++)
//    //    {
//    //        for (int j = 0; j < 8; j++)
//    //        {

//    //            Vector3 forGridPos = GridPosCalculator(i,j);
//    //            Vector3 activeGridPos = GridPosCalculator(nearestGrid.gridX, nearestGrid.gridY); 

//    //            float forGridDist = Vector3.Distance(forGridPos, dragGridPos);
//    //            float activeGridDist = Vector3.Distance(activeGridPos , dragGridPos);

//    //            if(forGridDist < activeGridDist)
//    //            {
//    //                nearestGrid.gridX = i;
//    //                nearestGrid.gridY = j;
//    //            }   
//    //        }
//    //    }

//    //    //Debug.Log(nearestGrid.gridX + " " + nearestGrid.gridY); 

//    //    if (GridMatrix[nearestGrid.gridX, nearestGrid.gridY] == null)
//    //    {
//    //        GridMatrix[nearestGrid.gridX, nearestGrid.gridY] = gridObject.obj;
//    //        GridMatrix[gridObject.gridX, gridObject.gridY] = null;
//    //        Vector3 targetPos = GridPosCalculator(nearestGrid.gridX , nearestGrid.gridY);
//    //        gridObject.obj.transform.DOMove(targetPos,.15f);

//    //        gridObject.gridX = nearestGrid.gridX;
//    //        gridObject.gridY = nearestGrid.gridY;
//    //        gridObject.gridPos = targetPos;
//    //        gridObject.obj.GetComponent<Resource>().gridObject = gridObject; 
//    //    }
//    //    else
//    //    {
//    //        GameObject swapObject = GridMatrix[nearestGrid.gridX, nearestGrid.gridY];
//    //        GameObject dragObject = gridObject.obj;

//    //        Vector3 targetPos = GridPosCalculator(nearestGrid.gridX, nearestGrid.gridY);
//    //        dragObject.transform.DOMove(targetPos, .15f);

//    //        Vector3 swapTargetPos = GridPosCalculator(gridObject.gridX, gridObject.gridY);
//    //        swapObject.transform.DOMove(swapTargetPos, .15f);

//    //        GridMatrix[gridObject.gridX, gridObject.gridY] = null;
//    //        GridMatrix[nearestGrid.gridX, nearestGrid.gridY] = null;

//    //        GridObj swapGridObject = swapObject.GetComponent<Resource>().gridObject;
//    //        swapGridObject.gridX = gridObject.gridX;
//    //        swapGridObject.gridY = gridObject.gridY;
//    //        swapGridObject.gridPos = gridObject.gridPos;
//    //        GridMatrix[swapGridObject.gridX, swapGridObject.gridY] = swapGridObject.obj;


//    //        gridObject.gridX = nearestGrid.gridX;
//    //        gridObject.gridY = nearestGrid.gridY;
//    //        gridObject.gridPos = targetPos;
//    //        gridObject.obj.GetComponent<Resource>().gridObject = gridObject;
//    //        GridMatrix[gridObject.gridX, gridObject.gridY] = gridObject.obj;


//    //    }

//    //}


//}

//[System.Serializable]
//public class GridObj
//{
//    public GameObject obj;
//    public int gridX;
//    public int gridY;
//    public Vector3 gridPos;
//}




