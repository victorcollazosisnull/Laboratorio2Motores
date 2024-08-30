using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    [Header("Velocidad")]
    [SerializeField] private float _horizontal;
    public float speed;
    [Header("Salto")]
    public float jumpForce;
    [SerializeField] private bool jumping = false;
    [SerializeField] private bool jumpDoble = false;
    [SerializeField] private bool enSuelo = false;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }
    }

    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_horizontal * speed, _rigidbody2D.velocity.y);

        if (jumping)
        {
            if (enSuelo)
            {
                _rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
                jumpDoble = true;
                enSuelo = false; 
            }
            else if (jumpDoble)
            {
                _rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
                jumpDoble = false; 
            }
            jumping = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true; 
            jumpDoble = true;
            jumping = false; 
        }
        if (collision.gameObject.CompareTag("Muerte"))
        {
            SceneManager.LoadScene("Resultado");
        }
        if (collision.gameObject.CompareTag("Victory"))
        {
            SceneManager.LoadScene("Resultado");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = false; 
        }
    }
}
