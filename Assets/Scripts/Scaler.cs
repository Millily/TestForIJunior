using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _scaleChange;
    [SerializeField] private float _maxScale;
    private float _minScale;

    private void Start()
    {
        _minScale = transform.localScale.y;
    }

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleChange * _speed * Time.deltaTime;

        if (transform.localScale.y < _minScale || transform.localScale.y > _maxScale)
        {
            _scaleChange = -_scaleChange;
        }
    }
}