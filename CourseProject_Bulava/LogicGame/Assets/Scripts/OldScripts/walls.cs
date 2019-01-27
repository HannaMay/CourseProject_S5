using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class walls : MonoBehaviour {

    public GameObject panel;

    public void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movie>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
            panel.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }        
    }
}
