using UnityEngine;

public class PolarCamera : MonoBehaviour
{
    float Radius;
    float Angle = 0;
    void Start()
    {
        Radius = transform.position.magnitude;
    }

    
    void Update()
    {
        transform.LookAt(Vector3.zero);
        float xPos = Radius * Mathf.Cos(Angle);
        float zPos = Radius * Mathf.Sin(Angle);

        transform.position = new Vector3(xPos, 0, zPos);

        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            Angle += 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {

            Angle -= 0.1f; 
                
        }
    }
}
