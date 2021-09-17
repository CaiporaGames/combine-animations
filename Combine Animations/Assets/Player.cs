using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            animator.SetBool("run", true);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            animator.SetBool("run", true);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            animator.SetBool("run", true);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
            animator.SetBool("run", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("wave", true);
        }




    }
}
