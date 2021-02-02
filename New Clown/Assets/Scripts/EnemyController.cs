using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float clownSpeed;
    private Transform target;
    public float playerDistance;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) < playerDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * clownSpeed);
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

    }
}
