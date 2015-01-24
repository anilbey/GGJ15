using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
				if (other.gameObject.tag == "Player")
						other.gameObject.GetComponent<PlayerControl> ().die = true;
				if (other.gameObject.tag == "Player2")
						other.gameObject.GetComponent<PlayerControl2> ().die = true;
		}

}
