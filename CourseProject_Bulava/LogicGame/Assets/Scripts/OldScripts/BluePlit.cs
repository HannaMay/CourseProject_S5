using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlit : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Movie>().speed += 0.3f;
            StartCoroutine(SpeedCoroutineBlue(collider));
        }
    }

    IEnumerator SpeedCoroutineBlue(Collider col)
    {
        yield return new WaitForSeconds(1f);
        col.GetComponent<Movie>().speed -= 0.3f;
        Destroy(this);
    }
}
