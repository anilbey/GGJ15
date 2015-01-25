using UnityEngine;
using System.Collections;

public class GravityShift : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (9,10);
	
	}

	void OnTriggerEnter2D(Collider2D other)

	{
		Debug.Log ("LAAHN");
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2") {

						if (other.gameObject.rigidbody2D.gravityScale == 2) {
								other.gameObject.rigidbody2D.gravityScale = -2F;
								other.gameObject.transform.localEulerAngles = new Vector3(0, 0, 180);
						}

			            else if (other.gameObject.rigidbody2D.gravityScale == -2) {
								other.gameObject.rigidbody2D.gravityScale = 2F;
								other.gameObject.transform.localEulerAngles = new Vector3 (0, 180, 0);
						}

			//Destroy(gameObject);
			//Debug.Break();
				}
	}

}
