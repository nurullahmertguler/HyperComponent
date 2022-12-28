using UnityEngine;

public class Drag : MonoBehaviour
{
    // �evirme h�z�n� ayarlamak i�in bir de�i�ken tan�mlay�n
    public float rotateSpeed = 10f;

    // Objeyi �evirme i�lemini ger�ekle�tirmek i�in Update() fonksiyonunu kullan�n
    void Update()
    {
        // E�er kullan�c� ekrana dokunursa...
        if (Input.GetMouseButton(0))
        {
            // ...objeyi �evirin
            transform.Rotate(Input.GetAxis("Mouse Y") * rotateSpeed, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        }
    }
}
