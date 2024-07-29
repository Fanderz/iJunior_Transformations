using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float _movementSpeed = 0.05f;

    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z -= _movementSpeed;
        transform.position = nextPosition;
    }
}
