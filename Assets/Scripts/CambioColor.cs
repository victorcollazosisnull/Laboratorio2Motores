using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void ColorCambio(Color color)
    {
        if (_spriteRenderer != null)
        {
            _spriteRenderer.color = color;
        }
    }
    public void Rojo()
    {
        ColorCambio(Color.red);
        Debug.Log("cambio a rojo");
    }
    public void Verde()
    {
        ColorCambio(Color.green);
        Debug.Log("cambio a verde");
    }
    public void Azul()
    {
        ColorCambio(Color.blue);
        Debug.Log("cambio a azul");
    }
    public Color ObtengoColor()
    {
        return _spriteRenderer.color;
    }
}
