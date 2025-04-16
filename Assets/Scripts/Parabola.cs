using UnityEngine;

public class Parabola : MonoBehaviour
{
    [SerializeField] GameObject point; 

    QuadraticFunction f = new QuadraticFunction(0.5f, 2, 3);
    void Start()
    {
        
    }

    
    void Update()
    {
        for (float x = -5; x < 5; x += 0.05f)
        {
            GameObject newPoint = Instantiate(point);
            //newPoint.transform.position = new Vector3(x, f.(x), 0);
        }
    }
}
