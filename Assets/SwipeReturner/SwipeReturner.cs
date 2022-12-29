using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeReturner : MonoBehaviour
{

    public enum Swipe { up , down , right ,left}
    public Swipe swipe = Swipe.up;


    Vector3 downPos , upPos;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            downPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            upPos = Input.mousePosition;

            MouseUpFunc(downPos , upPos);
        }


    }

    private void MouseUpFunc(Vector3 down , Vector3 up)
    {
        float xDown, xUp, yDown, yUp;

        xDown = down.x;
        yDown = down.y;
        xUp = up.x;
        yUp = up.y;


        float xDif = xDown - xUp;
        float yDif = yDown - yUp;

        if (Mathf.Abs(xDif) > Mathf.Abs(yDif))
        {
            //x

            if (xDif > 0)
            {
                //left
                swipe = Swipe.left;
            }
            else if (xDif < 0)
            {
                //right
                swipe = Swipe.right;
            }
        }
        else
        {
            //y

            if (yDif > 0)
            {
                //down
                swipe = Swipe.down;
            }
            else if (yDif < 0)
            {
                //up
                swipe = Swipe.up;
            }
        }

        

        

    }
}
