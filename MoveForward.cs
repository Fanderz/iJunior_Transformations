using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _movementSpeed = 5f;

    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition += transform.forward * _movementSpeed * Time.deltaTime;
        transform.position = nextPosition;
    }
}
