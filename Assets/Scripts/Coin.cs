using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float _speedRotation;
    private Transform _playerTransform;
    private CoinNumber _coinNumber;

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<Person>().transform;
        _coinNumber = FindObjectOfType<CoinNumber>();
        _speedRotation = 100;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, _playerTransform.position);
        if (distance < 2f)
        {
            _coinNumber.Number += 1;
            Destroy(gameObject);
        }

        transform.Rotate(0, 0, _speedRotation * Time.deltaTime);
    }
}
