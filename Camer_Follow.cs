using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_Follow : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public float sens = 100f;
    public Transform player;
    float XRotation = 0f;
    // Update is called once per frame
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);
        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(XRotation,0,0);

    }
}
