using UnityEngine;

public class GrowUp : MonoBehaviour
{
    [SerializeField] private Vector3 _growthRate;

    private void Update()
    {
        transform.localScale += _growthRate * Time.deltaTime;
    }
}
