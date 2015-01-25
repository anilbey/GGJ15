using UnityEngine;
using System.Collections;

public class moveupblocks : MonoBehaviour {

	public GameObject ground;
	public AudioClip cart;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other)	{
		ground.transform.Translate (new Vector3 (0, 3, 0));
		//Destroy (gameObject);
		gameObject.collider2D.enabled = false;
		audio.PlayOneShot (cart);
		}

	// Update is called once per frame
	void Update () {
	
	}
}
