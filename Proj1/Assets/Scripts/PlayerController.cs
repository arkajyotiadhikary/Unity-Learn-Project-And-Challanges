using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // varialbles
    private float speed = 20.0f;
    private float turn = 45.0f;
    private float horizoltal;
    private float forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizoltal = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");

        // move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime*speed*forward);   
        // transform.Translate(Vector3.right*Time.deltaTime*turn*horizoltal);
        // turn player
        transform.Rotate(Vector3.up*turn*Time.deltaTime*horizoltal);
    }
}
 