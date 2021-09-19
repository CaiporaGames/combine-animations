using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("hiphop", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            animator.SetBool("walk", false);
            animator.SetBool("hiphop", true);

        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("walk", true);
            animator.SetBool("hiphop", false);
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("walk", true);
            animator.SetBool("hiphop", false);
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetBool("walk", true);
            animator.SetBool("hiphop", false);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            animator.SetBool("walk", true);
            animator.SetBool("hiphop", false);
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("wave", true);
            StartCoroutine(SetWaveAnimationToFalse(1f));
        }
    }

    IEnumerator SetWaveAnimationToFalse(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetBool("wave", false);

    }
}
