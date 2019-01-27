using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturningToMenu : MonoBehaviour {

    public GameObject panel;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenPauseMenu()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movie>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
        panel.SetActive(true);
    }

    public void ClosePauseMenu()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movie>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = true;
        panel.SetActive(false);
    }

    public void ReloadLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
