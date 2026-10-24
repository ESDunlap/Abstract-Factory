using UnityEngine;
using UnityEngine.InputSystem;

public class cameraMovement : MonoBehaviour
{
    private float rotX;
    private float rotY;
    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * 3f;
        rotY += Input.GetAxis("Mouse Y") * 1f;
        transform.rotation = Quaternion.Euler(-rotY, rotX, 0);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = 0;
        if (Input.GetKey(KeyCode.E))
            y = 1;
        else if (Input.GetKey(KeyCode.Q))
            y = -1;
        Vector3 dir = transform.right * x + transform.up * y + transform.forward * z;
        transform.position += dir * 5f * Time.deltaTime;

        transform.Rotate(Input.GetAxis("Mouse Y")*Time.deltaTime * 50f, Input.GetAxis("Mouse X") * Time.deltaTime * 50f, 0);
    }
}
