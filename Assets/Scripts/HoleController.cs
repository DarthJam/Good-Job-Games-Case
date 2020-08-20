using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour
{
    [SerializeField] Camera main;
    [SerializeField] LayerMask layermask;
    Vector3 targetPos;

    IMove movement;

    private void Awake()
    {
        movement = GetComponent<IMove>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
            movement.Move(targetPos);
        }
    }

    private void SetTargetPosition()
    {
        Ray ray = main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000, layermask))
        {
            targetPos = hit.point;
        }
    }
}
