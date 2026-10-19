using UnityEngine;

public class TopDownMovement :MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;

    private Rigidbody2D rb;
    private float speedX;
    private float speedY;
    private int direction;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");
        if(speedY > 0){
            
            direction = 0;
        }
        else if (speedY < 0){
            if (speedX > 0){
                direction = 2;
            }
            if (speedX < 0){
                direction = 4;
            }
            else{
                direction = 3;
            }
        }
        else{
            if (speedX > 0){
                direction = 1;
            }
            else if (speedX < 0){
                direction = 5;
            }
        }
        animator.SetInteger("Direction", direction);
        animator.SetFloat("Speed", Mathf.Abs(speedX) + Mathf.Abs(speedY));
    }

    void FixedUpdate ()
    {
        rb.linearVelocity = new Vector2(speedX * moveSpeed, speedY * moveSpeed);
    }
}