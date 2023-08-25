using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem 복제오브젝트폭파효과;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Shell")
        {
            ParticleSystem tagetExpFire = Instantiate(복제오브젝트폭파효과, transform.position, Quaternion.identity);
            tagetExpFire.Play();
            Destroy (gameObject);
            Destroy(tagetExpFire.gameObject, 2.0f);
        }
    }
}
