using UnityEngine;

public class Inertia : MonoBehaviour
{
    [SerializeField] GameObject Ball1;
    [SerializeField] GameObject Ball2;
    Rigidbody rb1;
    Rigidbody rb2;

    Vector3 begin1;
    Vector3 begin2;


    void Start()
    {
        begin1 = Ball1.transform.position; 
        rb1 = Ball1.GetComponent<Rigidbody>();

        begin2 = Ball2.transform.position;
        rb2 = Ball2.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) 
        { 
            rb1.AddForce(new Vector3(1, 0, 0) * 100f, ForceMode.Force);
            rb2.AddForce(new Vector3(1, 0, 0) * 100f, ForceMode.Force);

        }

        if (Ball1.transform.position.y < -5)
        {
            rb1.linearVelocity = Vector3.zero;
            rb1.angularVelocity = Vector3.zero;
            Ball1.transform.position = begin1;
        }

        if (Ball2.transform.position.y < -5) 
        { 
            rb2.linearVelocity = Vector3.zero;
            rb2.angularVelocity = Vector3.zero;
            Ball2.transform.position = begin2;
        }

    }
}
