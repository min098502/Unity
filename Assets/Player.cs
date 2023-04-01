using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MaxHP = 100f;
    public float CurrentHP;
    public float speed;
    private Rigidbody rb;
    public Transform Enemy;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        rb.velocity = velocity;

        this.transform.LookAt(Enemy);
    }
}
