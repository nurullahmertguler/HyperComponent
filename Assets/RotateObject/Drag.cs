using UnityEngine;

public class Drag : MonoBehaviour
{
    // Çevirme hýzýný ayarlamak için bir deðiþken tanýmlayýn
    public float rotateSpeed = 10f;

    // Objeyi çevirme iþlemini gerçekleþtirmek için Update() fonksiyonunu kullanýn
    void Update()
    {
        // Eðer kullanýcý ekrana dokunursa...
        if (Input.GetMouseButton(0))
        {
            // ...objeyi çevirin
            transform.Rotate(Input.GetAxis("Mouse Y") * rotateSpeed, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        }
    }
}
