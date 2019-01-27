using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalls : MonoBehaviour {

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.GetComponent<Movie>().crystalls += 1;
            StartCoroutine(CoroutineAudio(collider));           
        }
    }

    IEnumerator CoroutineAudio(Collider col)
    {        
        audio.PlayOneShot(audio.clip);
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}
