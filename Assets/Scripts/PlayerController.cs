using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    private float inputValue;

    public float speed;

    private Vector2 direccion;


    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
            direccion = Vector2.right;
        else if (inputValue == -1)
            direccion = Vector2.left;
        else 
            direccion = Vector2.zero;

        rb.AddForce(direccion * speed * Time.deltaTime * 100);  

    }
}
