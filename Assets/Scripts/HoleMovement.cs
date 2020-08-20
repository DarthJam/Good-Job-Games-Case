using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HoleMovement : MonoBehaviour, IMove
{
    [SerializeField] private float speed = 5f;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 targetPos)
    {
        rb.MovePosition(Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime));

        //transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
