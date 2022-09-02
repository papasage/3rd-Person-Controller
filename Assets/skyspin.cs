using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyspin : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _rotateSpeed;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Rotation(_rb);
    }

    void Rotation(Rigidbody rb)
    {
        Quaternion turnOffset = Quaternion.Euler(0, _rotateSpeed, 0);
        rb.MoveRotation(_rb.rotation * turnOffset);
    }

}
