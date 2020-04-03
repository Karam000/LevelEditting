using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] Waypoints waypoints;

    Transform[] _MyTransforms;
    int _NextPoint = 0;
    bool _IsForward = true;
    [SerializeField] float _MovingSpeed = 1;
    [SerializeField] float _RotationSpeed = 1;


    // Start is called before the first frame update
    void Start()
    {
        _MyTransforms = waypoints.Translist;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }

    void Move()
    {
        Vector3 Target = _MyTransforms[_NextPoint].position;
        Target.y = transform.position.y;
        Vector3 MoveDirection = Target - transform.position;

        if (MoveDirection.sqrMagnitude < 0.02f)
        {
            if (_IsForward == true)
                _NextPoint++;
            else if (_IsForward == false)
                _NextPoint--;
        }
        else
        {
            Quaternion Roration = Quaternion.LookRotation(MoveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, Roration, Time.deltaTime * _RotationSpeed);
            //transform.LookAt(Target);
            transform.position = Vector3.MoveTowards(transform.position, Target, Time.deltaTime * _MovingSpeed);
        }
        if (_NextPoint == _MyTransforms.Length-1)
        {
            _IsForward = false;
        }
        else if(_NextPoint == 0)
        {
            _IsForward = true;
        }
    }
    
}
