using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndOfLevel : MonoBehaviour {

    public GameObject panel;

    public void OnTriggerEnter(Collider collider)
    {
        collider.GetComponent<Movie>().enabled = false;
        collider.GetComponent<Rigidbody>().useGravity = false;
        panel.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
