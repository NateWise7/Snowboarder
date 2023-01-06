using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float sceneDelayTime = .4f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && !hasCrashed) 
        {
            hasCrashed = true;
            FindObjectOfType<playerControls>().disableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", sceneDelayTime);
        }
    }
    void ReloadScene () {
        SceneManager.LoadScene(0);
    }
}
