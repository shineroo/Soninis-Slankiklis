using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;

    public Camera cam;
    Vector3 movement;
    Ray cameraRay;

    public GunController gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // walking inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        // mouse position
        cameraRay = cam.ScreenPointToRay(Input.mousePosition);

        // shoot
        if (Input.GetMouseButtonDown(0))
            gun.isFiring = true;
        if (Input.GetMouseButtonUp(0))
            gun.isFiring = false;
    }

    private void FixedUpdate()
    {
        // walk
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        // look
        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            transform.LookAt(pointToLook);
        }

        
    }
}
