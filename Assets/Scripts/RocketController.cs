using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float thrustForce = 5f;
    public float rotationSpeed = 180f;

    private Rigidbody2D rb;
    private Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update()
    {
        HandleThrust();
        HandleRotation();
        KeepInScreen();
    }

    void HandleThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * thrustForce);
        }
    }

    void HandleRotation()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            rotation = rotationSpeed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(0,0,rotation);
    }

    void KeepInScreen()
    {
        Vector3 pos = transform.position;
        Vector3 viewportPos = cam.WorldToViewportPoint(pos);

        if (viewportPos.x > 1) pos.x = cam.ViewportToWorldPoint(new Vector3(0, viewportPos.y, 0)).x; 
        if (viewportPos.x < 0) pos.x = cam.ViewportToWorldPoint(new Vector3(1, viewportPos.y, 0)).x;
        if (viewportPos.y > 1) pos.y = cam.ViewportToWorldPoint(new Vector3(viewportPos.x, 0, 0)).y;
        if (viewportPos.y < 0) pos.y = cam.ViewportToWorldPoint(new Vector3(viewportPos.x, 1, 0)).y;

        transform.position = pos;
    }
}
