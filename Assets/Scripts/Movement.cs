using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(SpiderRed))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = new Vector3(0, -_speed, 0);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0, -_speed*Time.deltaTime, 0);
    }
}