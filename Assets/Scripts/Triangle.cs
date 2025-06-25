using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] DragablePoint A;
    [SerializeField] DragablePoint B;
    [SerializeField] DragablePoint C;

    [SerializeField] Transform AB;
    [SerializeField] Transform BC;
    [SerializeField] Transform AC;

    [SerializeField] Transform Centroid;

    [SerializeField] LineRenderer lr;
    void Start()
    {
        
    }

    
    void Update()
    {
        lr.SetPosition(0,A.transform.position);
        lr.SetPosition(1,B.transform.position);
        lr.SetPosition(2,C.transform.position);

        AB.position = A.transform.position + 0.5f * (B.transform.position - A.transform.position);
        BC.position = B.transform.position + 0.5f * (C.transform.position - B.transform.position);
        AC.position = C.transform.position + 0.5f * (A.transform.position - C.transform.position);

        Centroid.position = (A.transform.position + B.transform.position + C.transform.position)/3;

    }
}
