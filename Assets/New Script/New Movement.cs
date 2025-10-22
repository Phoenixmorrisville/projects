using UnityEngine;
using UnityEngine.InputSystem;

public class NewMovement : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    Vector2 movePlayer;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myMove();
    }
    void OnMove(InputValue value)
    {
        movePlayer = value.Get<Vector2>();
        //Debug.Log(movePlayer);
    }
    void myMove()
    {
        //rb.linearVelocity = movePlayer;
        //rb.linearVelocity = movePlayer * Speed * Time.deltaTime;
        rb.linearVelocity = movePlayer * Speed;
        Debug.Log(rb.linearVelocity);
    }
}
