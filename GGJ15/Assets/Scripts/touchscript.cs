using UnityEngine;
using System.Collections;

public class touchscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void makefalse(){
		this.GetComponent<Animator> ().SetBool ("touch",false);

		}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other) {
		Debug.Log ("Hoyt");
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2") {
			this.GetComponent<Animator> ().SetBool ("touch",true);
			Invoke("makefalse",1.2f);
			Debug.Log ("Dayt");	
		}
					
	
	}
}
