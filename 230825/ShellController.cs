using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem 복제포탄폭파효과; //파티클시스템 대입 변수

    private void FixedUpdate()
    {
        if (this.gameObject.transform.position.y <= -1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        ParticleSystem shellExpFire = Instantiate(복제포탄폭파효과, transform.position, Quaternion.identity) as ParticleSystem;

        shellExpFire.Play(); //이벤트 실행(포탄 폭파 효과)
        Destroy(gameObject);
        Destroy(shellExpFire.gameObject, 2.0f);
    }    
}
