using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionToMouse : MonoBehaviour
{
    Vector3 worldPosition;
    public float depth = 10;
    // Update is called once per frame
    void Update()
    {
        Plane plane = new Plane(Vector3.forward, depth);

        float distance;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
        transform.position = worldPosition;
    }
}
