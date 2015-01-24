using UnityEngine;
using System.Collections;

public class 	VideoKontrol : MonoBehaviour {
	public MovieTexture movie;
	// Use this for initialization
	void Start () {
		movie.Play ();
		movie.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
