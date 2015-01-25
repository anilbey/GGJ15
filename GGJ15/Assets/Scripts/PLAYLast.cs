using UnityEngine;
using System.Collections;

public class PLAYLast : MonoBehaviour {
	public	 MovieTexture movTexture;
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = movTexture;
		movTexture.Play();

	}
	
	// Update is called once per frame
	void Update () {
		if (!movTexture.isPlaying)
		{
			Application.Quit();
		}
		
	}
}
