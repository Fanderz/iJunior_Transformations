using UnityEngine;

public class SecondCube : MonoBehaviour
{
    private float _growthRate = 0.01f;
    private float _movementSpeed = 0.05f;
    private float _rotationSpeed = 5f;

    private void Update()
    {
        Vector3 newScale = new Vector3(transform.localScale.x + _growthRate, transform.localScale.y + _growthRate, transform.localScale.z + _growthRate);
        transform.localScale = newScale;

        transform.Rotate(0, _rotationSpeed, 0);

        Vector3 nextPosition = transform.position;
        nextPosition.z += _movementSpeed;
        transform.position = nextPosition;
    }
}
