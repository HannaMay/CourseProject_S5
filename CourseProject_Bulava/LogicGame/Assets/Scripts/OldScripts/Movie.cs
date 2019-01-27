using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movie : MonoBehaviour {

    public float speed;
    public int crystalls;

    void Update () {
        transform.Translate(transform.worldToLocalMatrix.MultiplyVector(transform.forward) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A)) {
            transform.Rotate(new Vector3 (0, -20f, 0) );
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Quaternion quaternion = Quaternion.AngleAxis(20F, Vector3.up);
            transform.rotation *= quaternion;            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector2.up * 350);
        }
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}
