using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if(GetComponent<Animator>() != null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);

        if(animator != null)
        {
            animator.speed = speed;
        }
    }
}
