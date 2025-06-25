using UnityEditor;
using UnityEngine;

public class CircumCenter : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform C;

    [SerializeField] Transform mAB;
    [SerializeField] Transform mBC;
    [SerializeField] Transform mCA;

    Vector3 AB;
    Vector3 BC;
    Vector3 CA;

    [SerializeField] LineRenderer lr;

    MyRay normalAB;
    MyRay normalBC;

    [SerializeField] LineRenderer norAB;
    [SerializeField] LineRenderer norBC;
    void Start()
    {
        
    }

    
    void Update()
    {
        lr.SetPosition(0, A.position + new Vector3(0, 0, -2));
        lr.SetPosition(1, B.position + new Vector3(0, 0, -2));
        lr.SetPosition(2, C.position + new Vector3(0, 0, -2));

        mAB.position = (A.position + B.position) / 2;
        mBC.position = (B.position + C.position) / 2;
        mCA.position = (C.position + A.position) / 2;

        AB = (B.position - A.position).normalized;
        BC = (C.position - B.position).normalized;
        CA = (A.position - C.position).normalized;

        normalAB = new MyRay(mAB.position, new Vector3(AB.y, -AB.x, 0), 10);
        norAB.SetPosition(0, mAB.position);
        norAB.SetPosition(1, normalAB.getPoint(-10));

        normalBC = new MyRay(mBC.position, new Vector3(BC.y, -BC.x, 0), 10);
        norBC.SetPosition(0, mBC.position);
        norBC.SetPosition(1, normalBC.getPoint(-10));


    }
}
