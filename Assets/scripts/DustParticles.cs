using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem dustystuff;
    

    void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.tag == "Ground") {
            dustystuff.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            dustystuff.Stop();
        }
    }

}
