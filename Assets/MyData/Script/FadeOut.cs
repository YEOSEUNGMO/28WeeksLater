using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour {

	public float animTime=2f;

	private Image fadeImage;

	private float start=0f;
	private float end =1f;
	private float time =0f;

	private bool isPlaying = true;

	void Start () {
		fadeImage = GetComponent<Image>();
	}

	void Update () {
		if(isPlaying==true)
			StartCoroutine (Play ());
	}
	IEnumerator Play()
	{
		Color color = fadeImage.color;
		time = 0f;
		color.a = Mathf.Lerp (start, end, time);
		while (color.a < 1f) {
			time += Time.deltaTime / animTime;

			color.a = Mathf.Lerp (start, end, time);
			fadeImage.color = color;

			yield return null;
		}

		isPlaying = false;
	}
}
