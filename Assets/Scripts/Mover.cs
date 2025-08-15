using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private Vector3 _moveDirection;

    private void Update()
    {
        transform.Translate(_moveDirection.normalized * Time.deltaTime * _speed);
    }
}