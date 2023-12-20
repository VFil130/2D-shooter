using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour // управление персонажем
{
    public float speed = 0.1f;
    public Rigidbody2D physic;

    public bool isLeft = false;

    private bool isGrounded;
    private float floorRadius = 0.07f;

    public Transform floorcheck;
    public LayerMask floormask;
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");

        isGrounded = Physics2D.OverlapCircle(floorcheck.position, floorRadius,floormask);
        
        if (Input.GetKey(KeyCode.W) && isGrounded == true)
        {
            physic.AddForce(new Vector2(0, 7));
        }

        

        if (Input.GetAxis("Horizontal") < 0) // движение влево
        {
            GetComponent<SpriteRenderer>().flipX = true;
            isLeft= true;
        }
        if (Input.GetAxis("Horizontal") > 0) // движение вправо
        {
            GetComponent<SpriteRenderer>().flipX = false;
            isLeft= false;
        }
    }
}
