using UnityEngine;
using System.Collections;

public class CollisionIgnore2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (9, 9);
	
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="Player2")
		other.gameObject.GetComponent<PlayerControl2>().grounded=true;
	}
}
