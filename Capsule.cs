using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _growthRate;

    private void Update()
    {
        Vector3 newScale = new Vector3(transform.localScale.x + _growthRate, transform.localScale.y + _growthRate, transform.localScale.z + _growthRate);
        transform.localScale = newScale;
    }
}
