using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieControl : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CambioColor cambio = collision.gameObject.GetComponent<CambioColor>();

            if (cambio != null)
            {
                Color colorJugador = cambio.ObtengoColor();
                Color colorEnemigo = _spriteRenderer.color;
                if (colorJugador != colorEnemigo)
                {
                    collision.gameObject.GetComponent<VidaPlayer>().Damage(1);
                    Debug.Log("hago daño");
                }
                else
                {
                    Debug.Log("no hago daño");
                }
            }
        }
    }
}
