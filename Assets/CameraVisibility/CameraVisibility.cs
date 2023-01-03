using UnityEngine;

public class CameraVisibility : MonoBehaviour
{
    // Define the camera object
    public Camera camera;

    // Define the MeshRenderer object of the object this script is running
    MeshRenderer meshRenderer;

    void Start()
    {
        // Get the MeshRenderer object of the object this script is running
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Check if the object is visible by the camera
        if (meshRenderer.isVisible)
        {
            // If it is visible, open the mesh
            meshRenderer.enabled = true;
        }
        else
        {
            // If not visible, turn off mesh
            meshRenderer.enabled = false;
        }
    }
}
