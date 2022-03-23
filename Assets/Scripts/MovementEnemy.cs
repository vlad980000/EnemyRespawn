using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RespawnEnemy))]
public class MovementEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = new Vector3(transform.position.x + _speed * Time.deltaTime, transform.position.y);
    }
}
