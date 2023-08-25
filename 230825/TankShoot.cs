using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody 포탄복제; //리지드바디 컴포넌트
    public Transform fireTransform; //포탄의 위치
       
    void Update()
    {
     if (Input.GetButtonDown ("Fire1"))
        {
            Fire();
        }
    }
    void Fire ()
    {
        Rigidbody shell = Instantiate(포탄복제, fireTransform.position, fireTransform.rotation) as Rigidbody;
        shell.velocity = 25.0f * fireTransform.forward;
    }
}
