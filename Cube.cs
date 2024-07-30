using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private bool _isMoving;
    private float _growthRate = 0.01f;
    private float _movementSpeed = 0.05f;

    private void Update()
    {
        if(_isMoving)
        {
            transform.Rotate(0, _rotationSpeed, 0);

            Vector3 newScale = new Vector3(transform.localScale.x + _growthRate, transform.localScale.y + _growthRate, transform.localScale.z + _growthRate);
            transform.localScale = newScale;

            Vector3 nextPosition = transform.position;
            nextPosition += transform.forward*_movementSpeed;
            transform.position = nextPosition;
        }
        else
        {
            transform.Rotate(0, _rotationSpeed, 0);
        }
    }
}
