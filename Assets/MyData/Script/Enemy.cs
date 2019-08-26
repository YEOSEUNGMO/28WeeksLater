using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;
	Animator animator;

	void Start () {
		target = GameObject.Find ("Player");
		agent = GetComponent<NavMeshAgent> ();
		animator = GetComponentInChildren<Animator> ();
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if(target==null)
			target = GameObject.Find ("Player");
		agent.destination = target.transform.position;
		animator.SetFloat ("Speed", agent.velocity.magnitude);
	}
}
