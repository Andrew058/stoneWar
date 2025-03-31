using UnityEngine;

public class AlbertWalkJump : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private float horizontal; 
    private bool grounded; 
    private bool atacando;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        if (Input.GetMouseButtonDown(0) && !atacando && grounded)
        {
            Atacando();
        }

        _animator.SetBool("Walking", horizontal != 0.0f && grounded);
        _animator.SetBool("Jumping", !grounded && horizontal == 0.0f);
        _animator.SetBool("Wait", horizontal == 0.0f && grounded);
        _animator.SetBool("Attack", atacando);

        
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }
    }


    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = new Vector2(horizontal, _rigidbody2D.linearVelocity.y);
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * jumpForce);
    }

    private void Atacando()
    {
        atacando = true;
    }

    private void DesactivaAtaque()
    {
        atacando = false;
    }

    void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "floor")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "floor")
        {
            grounded = false;
        }
    }
}
