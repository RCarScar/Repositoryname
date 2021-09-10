using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPEw : MonoBehaviour
{
    public Transform target;
    public Collider2D other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
    void heckingheck()
    {
        Debug.Log("hi");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "dominopizza")
        {

        }
    }
}
