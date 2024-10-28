using UnityEngine;

public class Shooter_Controller : MonoBehaviour
{

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
            ));

        mousePos.x = Mathf.Clamp(mousePos.x, -2.1f, 2.1f);

        transform.position = new Vector3(mousePos.x, transform.position.y, transform.position.z);

    }
}