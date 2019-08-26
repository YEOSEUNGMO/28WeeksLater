using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene2_Ending : MonoBehaviour {

	void Start () {
		StartCoroutine (Ending());
	}
	
	void fixedUpdate () {
		
	}
	IEnumerator Ending(){
		yield return new WaitForSeconds (4);
		SceneManager.LoadScene ("Scene3");
	}
}
