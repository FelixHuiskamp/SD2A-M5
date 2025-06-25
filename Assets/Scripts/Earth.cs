using UnityEngine;

public class Earth : MonoBehaviour
{
    float t = 0;
    float r = 4;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(r * Mathf.Cos(t), 0, r * Mathf.Sin(t));
        transform.Rotate(0, -0.5f, 0);

        t += Time.deltaTime;
    }
}
