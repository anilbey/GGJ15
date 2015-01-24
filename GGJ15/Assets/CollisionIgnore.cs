using UnityEngine;
using System.Collections;

public class CollisionIgnore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (9, 9);
	
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="Player")
		other.gameObject.GetComponent<PlayerControl>().grounded=true;
	}
}
