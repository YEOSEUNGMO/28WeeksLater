using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	Quaternion defaultRoataion;

	void Start () {
		offset = transform.position - player.transform.position;
		defaultRoataion = transform.rotation;
	}

	void Update () {
		transform.position = player.transform.position + offset;

		if (Input.GetMouseButton(1)) {
			transform.Rotate (0, Input.GetAxisRaw ("Mouse X") * 5, 0);
		}

		if (Input.GetMouseButtonUp (1)) {
			transform.rotation = defaultRoataion;
		}
	}
}
