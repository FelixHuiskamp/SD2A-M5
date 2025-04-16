using UnityEngine;

public class EarthMoon : MonoBehaviour
{
    [SerializeField] GameObject Earth;
    [SerializeField] GameObject Moon;

    Vector3 Force;
    Vector3 Acceleration;
    Vector3 Velocity;

    void Start()
    {
        Velocity = new Vector3(1.2f, 1.3f, 0.1f);
    }

    
    void Update()
    {
        
        Force = (Earth.transform.position - Moon.transform.position).normalized;
        Acceleration = 1 * Force; 
        Velocity += Acceleration * Time.deltaTime;
        Moon.transform.position += Velocity * Time.deltaTime;

    }
}