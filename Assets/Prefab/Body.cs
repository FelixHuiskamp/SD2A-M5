using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField] Body[] bodies;

    Vector3 Force1 = Vector3.zero;
    Vector3 Force2 = Vector3.zero;
    Vector3 ForceTotal;

    Vector3 acceleration;
    [SerializeField] Vector3 velocity = new Vector3(.1f, -3f, .2f);
    void Start()
    {
        
    }

    
    void Update()
    {
        Force1 = (bodies[0].transform.position - transform.position).normalized;
        Force2 = (bodies[1].transform.position - transform.position).normalized;
        ForceTotal = Force1 + Force2;

        acceleration = ForceTotal; 
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}
