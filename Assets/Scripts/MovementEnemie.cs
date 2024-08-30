using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemie : MonoBehaviour
{
    [Header("Movimiento Enemigo")]
    public Vector2 puntoA; 
    public Vector2 puntoB;
    public float speed = 2f;
    private Vector2 direccion;
    private bool punto = true;
    void Start()
    {
        direccion = puntoB;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, direccion, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, direccion) < 0.1f)
        {
            if (punto)
            {
                direccion = puntoA;
            }
            else
            {
                direccion = puntoB;
            }
            punto = !punto;
        }
    }
}
