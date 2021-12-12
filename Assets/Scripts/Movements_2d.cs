using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements_2d : MonoBehaviour
{
    Animator animator_sc;
    SpriteRenderer Sprite;
    public float Speed = 10f;
    public float JumpForce = 2.5f;
    Rigidbody2D Physics;
    public bool isground = false;
    public LayerMask whereground;


    private void Awake()
    {

        Physics = GetComponent<Rigidbody2D>();
        Sprite = GetComponent<SpriteRenderer>();
        animator_sc = GetComponent<Animator>();
    }






    void Update()
    {
        isground = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 1.3f), new Vector2(transform.position.x + 0.5f, transform.position.y - 1.3f), whereground);
        animator_sc.SetBool("is Ground", isground);






        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Sprite.flipX = true;
            animator_sc.SetBool("Run", true);
            Physics.velocity = new Vector2(-Speed, Physics.velocity.y);
            
            

        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Sprite.flipX = false;
            animator_sc.SetBool("Run", true);
            Physics.velocity = new Vector2(Speed, Physics.velocity.y);
            
            


        }
        else if ((Input.GetKey("space") || Input.GetKey("w") || Input.GetKey("up")) && isground == true)
        {

            Physics.velocity = new Vector2(Physics.velocity.x, JumpForce);

        }
        else
        {
            animator_sc.SetBool("Run", false);
            Physics.velocity = new Vector2(0, Physics.velocity.y);
            
        }



    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 113, 0);
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 1.3f), new Vector2(1, 0.05f));
    }

}
