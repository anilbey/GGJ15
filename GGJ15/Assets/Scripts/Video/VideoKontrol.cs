using UnityEngine;
using System.Collections;

public class 	VideoKontrol : MonoBehaviour {
	public MovieTexture movie;
	// Use this for initialization
	void Start () {
		movie.Play ();
		movie.loop = false;
	}

	// Update is called once per frame
	void Update () {
		if (!movie.isPlaying)
			{
				Application.LoadLevel(2);
			}
	
	}
}
