using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(0,_rotationSpeed,0);
    }
}
