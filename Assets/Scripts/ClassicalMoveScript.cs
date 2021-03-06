using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicalMoveScript : MonoBehaviour
{
    public float speed = 10;
    public GameObject heckinghecks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetMouseButtonDown(0))
        {
            BlastStraightToHeck();
        }
    }
    void BlastStraightToHeck()
    {
        heckinghecks.SendMessage("heckingheck");
    }
}
