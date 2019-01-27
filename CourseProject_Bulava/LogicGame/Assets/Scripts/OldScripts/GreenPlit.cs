using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlit : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Movie>().speed -= 0.2f;
            StartCoroutine(SpeedCoroutine(collider));
        }
    }

    IEnumerator SpeedCoroutine(Collider col)
    {
        yield return new WaitForSeconds(1f);
        col.GetComponent<Movie>().speed += 0.2f;
        Destroy(this);
    }
}
