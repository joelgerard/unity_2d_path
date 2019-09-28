using System.Collections.Generic;
using UnityEngine;

public class PathGameObject : MonoBehaviour
{
    List<Vector3> points = new List<Vector3>();
    LineRenderer lineRenderer;

    void Start()
    {
        
    }

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        
    }

    public Vector2 GetPosition(int index)
    {
        return points[index];
    }

    public void AddPosition(Vector3 position)
    {
        points.Add(position);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());

    }

    public int Count()
    {
        return points.Count;
    }
}
