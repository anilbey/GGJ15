using UnityEngine;
using System.Collections;

public class MenuyeDon : MonoBehaviour 
{
	public GameObject kamera;
	public GameObject menu;
	public AudioClip SecimSes;
	public AudioClip SecimBasSes;
	
	void Start()
	{
		kamera = GameObject.Find("Kamera");
		menu = GameObject.Find("Menu");
	}
	
	void OnMouseEnter() 
	{
		audio.clip = SecimSes;
		audio.Play(); 
    }
	
	void OnMouseOver() 
	{
		renderer.material.color = Color.blue;
    }
	void OnMouseExit() 
	{
		renderer.material.color = Color.white;
    }
	void OnMouseDown() 
	{
		audio.clip = SecimBasSes;
		audio.Play();
		
		RotateCamera();
    }
	
	void RotateCamera()
	{
		kamera.GetComponent<YumusakGecis>().target = menu.transform;
	}
}
