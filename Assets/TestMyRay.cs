using UnityEngine;

public class TestMyRay : MonoBehaviour
{
    [SerializeField] Transform Support;
    [SerializeField] Transform Direction;

    [SerializeField] LineRenderer lr;

    MyRay myRay = new MyRay(Vector3.zero, Vector3.zero, 0f);

    void Start()
    {
        
    }

    
    void Update()
    {
        myRay.SupportVector = Support.position;
        myRay.DirectionVector = (Direction.position - Support.position);
        myRay.LineParameter = 10f;

        lr.SetPosition(0, myRay.SupportVector);
        lr.SetPosition(1, myRay.getPoint(10));   
    }
}
