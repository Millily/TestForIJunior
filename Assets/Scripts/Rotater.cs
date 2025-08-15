using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speed; 

    void Update()
    {
        transform.Rotate(transform.up, _speed * Time.deltaTime);
    }
}