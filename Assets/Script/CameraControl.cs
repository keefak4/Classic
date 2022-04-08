using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class CameraControl : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelosity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveVelosity = moveInput.normalized * speed;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelosity * Time.fixedDeltaTime);
    }
}
