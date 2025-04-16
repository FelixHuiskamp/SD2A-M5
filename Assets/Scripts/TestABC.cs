using UnityEngine;

public class TestABC : MonoBehaviour
{
    QuadraticFunction f = new QuadraticFunction(2, -3,-5);
    void Start()
    {
        print(f.findZero());
    }


    void Update()
    {
        
    }
}
