using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Boat : MonoBehaviour {

	public float speed;

	void Start () {

	}

	void Update () {

		if (transform.localPosition.x >= -200)
			transform.Translate(-speed*Time.deltaTime,0,0);
		//if (transform.localPosition.x <= -70)
	}
	void OnTriggerEnter(Collider other){
		switch (other.gameObject.name) {
		case "Go_Scene5":
			GameObject.Find ("FadeOut").GetComponent<FadeOut> ().enabled = true;
			StartCoroutine (Go_Scene5());
			break;
		default:
			break;
		}
	}
	IEnumerator Go_Scene5(){
		yield return new WaitForSeconds (4);
		SceneManager.LoadScene ("Scene5");
	}
}