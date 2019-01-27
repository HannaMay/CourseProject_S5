using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class demo : MonoBehaviour {

    [SerializeField] List<Sprite> images;
    [SerializeField] Image playable;

	void Start () {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movie>().enabled = false;
        playable.sprite = images[0];
        StartCoroutine(Learning());
	}

    IEnumerator Learning()
    {
        for (int i = 0; i < images.Count; i++)
        {
            playable.sprite = images[i];
            yield return new WaitForSeconds(4f);
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movie>().enabled = true;
        Destroy(this.gameObject);
    }
}
