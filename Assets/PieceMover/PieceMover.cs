using UnityEngine;

public class PieceMover : MonoBehaviour
{
    [SerializeField] GameObject activeObj;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ObjControl();
        }
        else if (Input.GetMouseButton(0) && activeObj != null)
        {
            MoveTheObj();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            activeObj = null;
        }
    }

    void ObjControl()
    {
        RaycastHit hit;
        float rayDist = 50;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        int layerMask = 1 << 7; //it just hits the layer with the collider of object layer 8

        Debug.DrawRay(ray.origin, ray.direction * rayDist, Color.blue);
        var raycast = Physics.Raycast(ray, out hit, rayDist, layerMask);

        if (raycast && hit.collider.gameObject.transform.parent.GetComponent<JigPiece>() != null)
        {
            activeObj = hit.collider.transform.parent.gameObject;
        }
        else
        {
            activeObj = null;
        }
    }

    void MoveTheObj()
    {
        float speed = 99;

        // Get mouse position.
        float mouseX = Input.mousePosition.x;
        float mouseZ = Input.mousePosition.y;

        // Convert mouse position to 3D world coordinates using the camera.
        float dist = Vector3.Distance(activeObj.transform.position , Camera.main.gameObject.transform.position);
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseZ, dist));

        // Get the object position and keep the Y value constant.
        Vector3 objPosition = activeObj.transform.position;
        objPosition.y = 0f;

        // Move the object position closer to the mouse position.
        objPosition = Vector3.MoveTowards(objPosition, mouseWorldPosition, speed * Time.deltaTime);

        // Update the object position with the fixed Y value.
        objPosition.y = activeObj.transform.position.y;
        activeObj.transform.position = objPosition;
    }
}
