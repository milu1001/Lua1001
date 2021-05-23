using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rigBody;
    public float jumpSpeed = 10f;
    bool isGrounded;
    public LayerMask whatIsGround;
    public float rayDistance;
    private RaycastHit2D groundCheckRay;
    bool isJumping = false;
    private float jumpTime;
    public float jumpBuffer = 0.1f;
    bool safetyOn = false;


    // Start is called before the first frame update

    void Start()
    {
        isGrounded = true;
        rigBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        groundCheckRay = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, whatIsGround);

        if (groundCheckRay.collider != null)
        {
            isGrounded = true;
            if (!safetyOn)
            {
                jumpTime = Time.time + jumpBuffer;
            }
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
        Debug.DrawRay(transform.position, new Vector2(0, -rayDistance), Color.blue); 
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (isJumping && isGrounded)
        {
            if (!safetyOn)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
                safetyOn = true;
            }
            isJumping = false;
        }
        else if (jumpTime < Time.time)
        {
            isGrounded = false;
            safetyOn = false;
        }
      
    }

}
