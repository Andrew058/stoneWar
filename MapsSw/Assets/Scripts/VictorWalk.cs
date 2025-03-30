using UnityEngine;

public class VictorWalk : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float horizontal; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }


    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = new Vector2(horizontal, _rigidbody2D.linearVelocity.y);
    }
}
