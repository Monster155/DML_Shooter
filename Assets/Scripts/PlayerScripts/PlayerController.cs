using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10;
    public float jumpPower = 1000;
    public BoxCollider boxCollider;
    private bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        //movement
        float forward = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        float right = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;

        transform.Translate(Vector3.forward * forward);
        transform.Translate(Vector3.right * right);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Platform"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Platform"))
            isGrounded = false;
    }
}