using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	[SerializeField] private GameObject _loading;
	[SerializeField] private int _numOfLevel;

	public void Start(){
		_loading.SetActive (true);
		StartCoroutine (AsyncLoad());
	}

	private IEnumerator AsyncLoad(){
		AsyncOperation operation = SceneManager.LoadSceneAsync (_numOfLevel);
		yield return null;
	}
}
