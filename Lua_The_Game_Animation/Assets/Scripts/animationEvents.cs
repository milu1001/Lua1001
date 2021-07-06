using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationEvents : MonoBehaviour
{
    private climb cl;
    private Character2DController cc;
    private GameObject Lua;
    private Rigidbody2D rb;
    public float moveUp;
    public float moveToSide;
    private float time = 0.1f;
    public float upAniLength;
    public float sideAniLength;

    private void Awake()
    {
        cl = GameObject.FindGameObjectWithTag("Player").GetComponent<climb>();
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        Lua = GameObject.FindGameObjectWithTag("Player");
        rb = Lua.GetComponent<Rigidbody2D>();
        
    }
    public void lockMovement()
    {
        cl.enabled = false;
        cc.enabled = false;
        rb.velocity = Vector2.zero;
    }

    public void unlockMovement()
    {
        cl.enabled = true;
        cc.enabled = true;
        rb.gravityScale = 1;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
    public void MoveUpwards()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.gravityScale = 0;
        Vector3 LuaPos = Lua.transform.position;
        Vector3 newPos = new Vector3(LuaPos.x, LuaPos.y + moveUp, LuaPos.z);
        StartCoroutine(waitASec(LuaPos,newPos, upAniLength));
    }
    IEnumerator waitASec(Vector3 LuaPos,Vector3 newPos, float length)
    {
        
        for (float i = 0; i <= length; i += 0.1f)
        {
            Lua.transform.position = Vector3.Lerp(LuaPos, newPos, (i/length));
            yield return new WaitForSecondsRealtime(time/10);
            
        }
        
    }

    public void MoveSidewards()
    {
        Vector3 LuaPos = Lua.transform.position;
        

        if (cl.isFacingRight)
        {
            Vector3 newPos = new Vector3(LuaPos.x + moveToSide, LuaPos.y, LuaPos.z);
            StartCoroutine(waitASec(LuaPos, newPos, sideAniLength));
        }
        else 
        {
            Vector3 newPos = new Vector3(LuaPos.x - moveToSide, LuaPos.y, LuaPos.z);
            StartCoroutine(waitASec(LuaPos, newPos, sideAniLength));
        }
    }


}
