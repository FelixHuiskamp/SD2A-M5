using NUnit.Framework.Constraints;
using UnityEngine;

public class myMesh : MonoBehaviour
{
    [SerializeField] MeshFilter meshFilter;
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;
    
    Matrix2x2 matrix2x2 = new Matrix2x2();

    void Start()
    {
        mesh = new Mesh();
        meshFilter.mesh = mesh;

        vertices = new Vector3[]
        {
            new Vector3 (0, 0, 0),
            new Vector3 (0.5f, 1, 0),
            new Vector3 (1, 0, 0),
        };

        triangles = new int[]
        {
            0,1,2
        };

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.uv = new Vector2[]
        {
            new Vector2 (0, 0),
            new Vector2 (0.5f, 1),
            new Vector2 (1, 0),
        };
        mesh.RecalculateNormals();

        Vector3 test = new Vector3(1, 2, 0);
        matrix2x2.matrix[0, 0] = 1;
        matrix2x2.matrix [0, 1] = 1;
        matrix2x2.matrix [1, 1] = 1;
        //Debug.Log(matrix2x2.MultiplyWithVector(test));

        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = matrix2x2.MultiplyWithVector(vertices[i]); 
        }
        mesh.vertices = vertices;
    }

    
    void Update()
    {
        
    }
}
