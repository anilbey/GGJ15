using UnityEngine;
using System.Collections;

public class MovingGround : MonoBehaviour {

	public GameObject ground;
	public bool isActive=false;
	// Use this for initialization
	void Start () {
	
	}
	
	void makefalse(){
		this.GetComponent<Animator> ().SetBool ("touch",false);
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other) {
		if (!isActive) {
			isActive=true;
						if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2") {
								this.GetComponent<Animator> ().SetBool ("touch", true);

								ground.transform.Translate (new Vector3 (0, -7, 0));

								//Invoke("makefalse",1.2f);
						}
				}
		
	}

	void OnCollisionExit2D (Collision2D other) {
		if (isActive) {
						isActive = false;

						if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2") {
								this.GetComponent<Animator> ().SetBool ("touch", false);
			
								ground.transform.Translate (new Vector3 (0, 7, 0));
			
								//Invoke("makefalse",1.2f);
						}
				}
		
	}
	/*
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButton(0))
		{
			if (ground.transform.position.y > -2.3)
				ground.transform.Translate(new Vector3(0,-5*Time.deltaTime,0));
		}
		else
		{
			if (ground.transform.position.y < 2.45)
				ground.transform.Translate(new Vector3(0,5*Time.deltaTime,0));}

	}
*/
}
