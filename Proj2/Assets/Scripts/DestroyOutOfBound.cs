using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z<-topBound)
        {
            Debug.Log("Game Over!!");
        }
    }
}
