using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climb : MonoBehaviour
{
    public LayerMask whatIsLadder;
    private RaycastHit2D climbCheck;
    private RaycastHit2D edgeCheck;
    public Rigidbody2D rb;
    public float rayDistance;
    private float inputVertical;
    private bool isClimbing = false;
    public float climbingSpeed = 1f;
    private bool isFacingRight = false;
    public float rayOffset;
    public float rayOffset2;
    Vector2 rayPos; 
    Vector2 rayPos2;
    public Animator luaanimator;
    private bool foundAnEdge = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        rayPos = new Vector2(transform.position.x, transform.position.y - rayOffset);
        rayPos2 = new Vector2(transform.position.x, transform.position.y - rayOffset2);
        if (transform.rotation.y != 0)
        {
            isFacingRight = true;
            climbCheck = Physics2D.Raycast(rayPos, Vector2.right, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos, new Vector2(rayDistance, 0), Color.blue);

            edgeCheck = Physics2D.Raycast(rayPos2, Vector2.right, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos2, new Vector2(rayDistance, 0), Color.red);
        }
        else
        {
            isFacingRight = false;
            climbCheck = Physics2D.Raycast(rayPos, Vector2.left, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos, new Vector2(-rayDistance, 0), Color.blue);

            edgeCheck = Physics2D.Raycast(rayPos2, Vector2.left, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos2, new Vector2(-rayDistance, 0), Color.red);
        }

        if (climbCheck.collider != null )
        {
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                isClimbing = true;
                luaanimator.SetBool("isMonkey", true);
            }
        }
        else
        {
            isClimbing = false;
            foundAnEdge = false;
            luaanimator.SetBool("isMonkey", false);
            luaanimator.SetBool("isclimbing", false);
            luaanimator.SetBool("isclimbingreverse", false); 
        }

        if (edgeCheck.collider != null)
        {
            foundAnEdge = false;
        }
        else
        {
            foundAnEdge = true;
        }

        if (isClimbing && foundAnEdge && rb.velocity.y > 0)
        {
            luaanimator.speed = 1;
            luaanimator.SetTrigger("foundEdge");
        }
        if (isClimbing)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(0, inputVertical * climbingSpeed);

        }
        else
        {
            rb.gravityScale = 1f;
            luaanimator.SetBool("isclimbing", false);
            luaanimator.SetBool("isclimbingreverse", false);
            luaanimator.speed = 1;
        }

        if (isClimbing && Input.GetAxisRaw("Vertical") == 1)
        {
            luaanimator.speed = 1;
            luaanimator.SetBool("isclimbingreverse", false);
            luaanimator.SetBool("isclimbing", true);
        }
        else if (isClimbing && Input.GetAxisRaw("Vertical") == -1)
        {
            luaanimator.speed = 1;
            luaanimator.SetBool("isclimbing", false);
            luaanimator.SetBool("isclimbingreverse", true);
        }
        else if (isClimbing && Input.GetAxisRaw("Vertical") == 0 && !foundAnEdge )
        {
            luaanimator.speed = 0;
        }

        

    }
}
