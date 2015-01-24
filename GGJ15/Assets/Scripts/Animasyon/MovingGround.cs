using UnityEngine;
using System.Collections;

public class MovingGround : MonoBehaviour {

	public GameObject ground;

	// Use this for initialization
	void Start () {
	
	}
	
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
				ground.transform.Translate(new Vector3(0,5*Time.deltaTime,0));

		}

	}

}
