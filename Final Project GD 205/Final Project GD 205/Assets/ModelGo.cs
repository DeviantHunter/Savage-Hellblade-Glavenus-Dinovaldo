using UnityEngine;
using System.Collections;

public class ModelGo : MonoBehaviour {
	Animator myAnimator;
	int Animstate;


	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			Animstate = 1;

			myAnimator.SetInteger ("currentState", Animstate);
		}
	}
}
