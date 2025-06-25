using UnityEngine;

public class Moon : MonoBehaviour
{
    [SerializeField] Transform Origin;
    float t = 0;
    float r = 1.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(r * Mathf.Cos(t) + Origin.position.x, 0, r * Mathf.Sin(t) + Origin.position.z);
        
        t += Time.deltaTime;
    }
}
