using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climb : MonoBehaviour
{
    public LayerMask whatIsLadder;
    private RaycastHit2D climbCheck;
    public Rigidbody2D rb;
    public float rayDistance;
    private float inputVertical;
    private bool isClimbing = false;
    public float climbingSpeed = 1f;
    private bool isFacingRight = false;
    public float rayOffset;
    Vector2 rayPos;
    public Animator luaanimator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rayPos = new Vector2(transform.position.x, transform.position.y - rayOffset);
        if (transform.rotation.y != 0)
        {
            isFacingRight = true;
            climbCheck = Physics2D.Raycast(rayPos, Vector2.right, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos, new Vector2(rayDistance, 0), Color.blue);
        }
        else
        {
            isFacingRight = false;
            climbCheck = Physics2D.Raycast(rayPos, Vector2.left, rayDistance, whatIsLadder);
            Debug.DrawRay(rayPos, new Vector2(-rayDistance, 0), Color.blue);
        }

        if (climbCheck.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) )
            {
                isClimbing = true;

            }
        }
        else
        {
            if ((isFacingRight && Input.GetKeyDown(KeyCode.LeftArrow)) || (!isFacingRight && Input.GetKeyDown(KeyCode.RightArrow)))
            {
                isClimbing = false;
                
            }
        }
        if (isClimbing && climbCheck.collider != null && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            luaanimator.SetBool("ishanging", true);
            luaanimator.SetBool("isrunning", false);
        }

        if (isClimbing && climbCheck.collider != null && Input.GetKey(KeyCode.UpArrow))
            {
                 luaanimator.SetBool("isclimbing", true);
            }
        else if (isClimbing && climbCheck.collider != null && !Input.GetKey(KeyCode.UpArrow))
            {
                 luaanimator.SetBool("isclimbing", false);
                 luaanimator.SetBool("ishanging", true);
            }

        if (isClimbing && climbCheck.collider != null && Input.GetKey(KeyCode.DownArrow))
            {
                 luaanimator.SetBool("isclimbingreverse", true);
            }
        else if (isClimbing && climbCheck.collider != null && !Input.GetKey(KeyCode.DownArrow))
            {
                 luaanimator.SetBool("isclimbingreverse", false);
                 luaanimator.SetBool("ishanging", true);
            }
        
            if (isClimbing && climbCheck.collider != null)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(0, inputVertical * climbingSpeed);
           // luaanimator.SetBool("isclimbing", true);

        }
        else
        {
            rb.gravityScale = 1f;
            luaanimator.SetBool("isclimbing", false);
            luaanimator.SetBool("isclimbingreverse", false);

        }
        
    }
}