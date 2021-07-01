using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
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
    public Animator luaanimator;
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public GameObject Bone;
    public HingeJoint2D lanternJoint;
    private Rigidbody2D _rigidbody;



    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }


    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
          
        
        //if (!Mathf.Approximately(0, movement))
        //{
        //    luaanimator.SetTrigger("isturning");
        //}
   
        if (Input.GetAxis("Horizontal") != 0)
        {
            luaanimator.SetBool("isrunning", true);
        }
        else
        {
            luaanimator.SetBool("isrunning", false);
        }
        groundCheckRay = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, whatIsGround);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
            luaanimator.SetTrigger("isjumping");
            luaanimator.SetBool("isrunning", false);
        }
        if (groundCheckRay.collider != null)
        {
            isGrounded = true;
            if (!safetyOn)
            {
                jumpTime = Time.time + jumpBuffer;
                luaanimator.SetBool("isfalling", false);
            }
            
        }
        else
        {
            if (luaanimator.GetBool("isclimbing") == (true) || luaanimator.GetBool("isclimbingreverse") == (true))
            // (luaanimator.GetComponent().GetBool("isclimbing") == (true) )
            {
                luaanimator.SetBool("isfalling", false);
            }
            else
            {
                luaanimator.SetBool("isfalling", true);
            }
            luaanimator.SetBool("isrunning", false);
        }


        //Debug.DrawRay(transform.position, new Vector2(0, -rayDistance), Color.blue);

      //  lanternJoint.connectedAnchor = new Vector2(_rigidbody.transform.position.x - Bone.transform.position.x, _rigidbody.transform.position.y - Bone.transform.position.y); 

    }
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
            luaanimator.ResetTrigger("isjumping");

        }
        else if (jumpTime < Time.time)
        {
            isGrounded = false;
            safetyOn = false;

        }

    }

}