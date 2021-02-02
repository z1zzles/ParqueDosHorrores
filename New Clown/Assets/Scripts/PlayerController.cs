using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public int moveSpeed;
    SpriteRenderer flip;
    bool isFlipped = false;
    //public static PlayerController player;
    public static Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.x == 0 && rb2d.velocity.y == 0){
            animator.SetBool("idleFront", true);
            animator.SetBool("walkForward", false);
            animator.SetBool("walkUp", false);
            animator.SetBool("walkSide", false);
        }else if (rb2d.velocity.y < 0 && rb2d.velocity.x == 0){
            animator.SetBool("idleFront", false);
            animator.SetBool("walkUp", false);
            animator.SetBool("walkForward", true);
            animator.SetBool("walkSide", false);
        }else if (rb2d.velocity.y > 0 && rb2d.velocity.x == 0){
            animator.SetBool("idleFront", false);
            animator.SetBool("walkForward", false);
            animator.SetBool("walkUp", true);
            animator.SetBool("walkSide", false);
        }else if(rb2d.velocity.x != 0 && rb2d.velocity.y == 0){
            animator.SetBool("walkSide", true);
            animator.SetBool("idleFront", false);
            if(rb2d.velocity.x < 0 && isFlipped == false){
                GetComponent<SpriteRenderer>().flipX = true;
                isFlipped = true;
            }else if(rb2d.velocity.x > 0 && isFlipped == true){
                isFlipped = false;
                GetComponent<SpriteRenderer>().flipX = false;
            }else if(rb2d.velocity.x == 0 && rb2d.velocity.y == 0)
            {
                animator.SetBool("walkSide", false);
            }
        }
    }
}


