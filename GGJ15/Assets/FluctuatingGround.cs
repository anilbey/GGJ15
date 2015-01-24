using UnityEngine;
using System.Collections;

public class FluctuatingGround : MonoBehaviour {

	public float speed;
	public bool yon;
	// Use this for initialization
	void Start () {
		yon = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.Translate(new Vector3(0, ((yon) ? 1 : -1) *speed*Time.deltaTime, 0));

		if (yon == false && (this.transform.position.y <= -5))
			yon = true;
		else if (yon == true && this.transform.position.y >= 7.5)
			yon = false;



	}
}
