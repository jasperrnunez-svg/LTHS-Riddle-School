using UnityEngine;
using TMPro;

public class TopDownMovement :MonoBehaviour
{
    public Animator anim;
    public float moveSpeed;

    private Rigidbody2D rb;
    private float speedX;
    private float speedY;
    private string animationName;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");
        if(speedY > 0){
            animationName = "WalkAway";
        }
        else if (speedY < 0){
            animationName = "WalkForward";
        }
        else{
            if (speedX > 0){
                animationName = "WalkRight";
            }
            else if (speedX < 0){
                animationName = "WalkLeft";
            }
        }
        if((Mathf.Abs(speedX) + Mathf.Abs(speedY)) != 0){
            anim.Play(animationName);
        }
        else{
            anim.Play("Idle");
        }
    }

    void FixedUpdate ()
    {
        rb.linearVelocity = new Vector2(speedX * moveSpeed, speedY * moveSpeed);
    }
}