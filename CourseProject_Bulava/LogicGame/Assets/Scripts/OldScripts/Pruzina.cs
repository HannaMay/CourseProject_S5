using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruzina : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
        collider.GetComponent<Rigidbody>().AddForce(Vector2.up * 400);
    }
}
