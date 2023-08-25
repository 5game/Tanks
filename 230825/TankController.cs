using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    string moveAxisName; 
    string rotationAxisName;    
   public float MoveSpeed = 10.0f; //이동속도 
   public float RotationSpeed = 150.0f; //회전 속도
    float tankMove = 0; //탱크가 전진 후진 하기 위해 필요한 값
    float tankRotation = 0;  //탱크가 오른쪽 왼쪽으로 회전 하기 위해 필요한 값

    void Start()
    {
        moveAxisName = "Vertical";
        rotationAxisName = "Horizontal" ;      
    }  
             
    
    void Update()
    {
      if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            tankMove = Input.GetAxis(moveAxisName) * MoveSpeed * Time.deltaTime;
            tankRotation = Input.GetAxis(rotationAxisName) * RotationSpeed * Time.deltaTime;
            transform.Translate(0, 0, tankMove);
            transform.Rotate(0, tankRotation, 0);
       }      
    }
}
