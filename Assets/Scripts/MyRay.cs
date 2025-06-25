using UnityEngine;

public class MyRay 
{
    public Vector3 SupportVector;
    public Vector3 DirectionVector;

   public float LineParameter;


    MyRay normalAB;
    MyRay normalBC;

    public MyRay(Vector3 SupportVector, Vector3 DirectionVector, float LineParameter)
    {
        this.SupportVector = SupportVector;
        this.DirectionVector = DirectionVector.normalized; 
        this.LineParameter = LineParameter;
    }

    public MyRay() 
    { 
        normalAB = new MyRay();
    }

    public Vector3 getPoint(float LineParameter)
    {
        return this.SupportVector + LineParameter * this.DirectionVector;
    }
}
