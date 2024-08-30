using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraControl : MonoBehaviour
{
    public GameObject objectivo;
    public float minX;
    public float maxX;
    public float positionX;
    public float minY;
    public float maxY;
    public float positionY;
    void Update()
    {
        positionX = Mathf.Clamp(objectivo.transform.position.x, minX, maxX);
        positionY = Mathf.Clamp(objectivo.transform.position.y, minY, maxY);
        transform.position = new Vector3(positionX, positionY, -10);
    }
}
