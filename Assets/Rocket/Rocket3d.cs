using UnityEditor;
using UnityEngine;

public class Rocket3d : MonoBehaviour
{
    [SerializeField] Transform Earth;
    [SerializeField] Transform Moon;

    Vector3 Force;
    Vector3 acceleration;
    Vector3 velocity;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3  ForceEarthRocket = (transform.position - Earth.position).normalized;
        Vector3 ForceMoonRocket = (transform.position - Moon.position).normalized;
        Force = ForceEarthRocket + ForceMoonRocket;

        acceleration = Force;
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}
