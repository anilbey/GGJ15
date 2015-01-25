using UnityEngine;
using System.Collections;

public class destroyintime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("killself",4f);
	
	}
	
	// Update is called once per frame
	void killself () {
	
		Destroy (gameObject);
	}
}
