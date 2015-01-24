using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	private GameObject kamera;
	public GameObject bolumSec;
	public GameObject kontroller;
	public GameObject jenerik;
	public bool Oyna = false;
	public bool BolumSec = false;
	public bool Kontroller = false;
	public bool Jenerik = false;
	public bool Cikis = false;
	public AudioClip SecimSes;
	public AudioClip SecimBasSes;

		
	void Start()
	{
		kamera = GameObject.Find("Kamera");
		bolumSec = GameObject.Find("Bolum Sec");
		kontroller = GameObject.Find("Kontroller");
		jenerik = GameObject.Find("Jenerik");
	}
	
	
	void OnMouseEnter() 
	{
		audio.clip = SecimSes;
		audio.Play(); 
    }
	
	void OnMouseOver() 
	{
		if (Oyna) 
		{
			renderer.material.color = Color.blue;
		}
		else if (BolumSec) 
		{
			renderer.material.color = Color.green;
		}
		else if (Kontroller) 
		{
			renderer.material.color = Color.yellow;
		}
		else if (Jenerik) 
		{
			renderer.material.color = Color.cyan;
		}
		else if (Cikis) 
		{
			renderer.material.color = Color.red;
		}
    }
	void OnMouseExit() 
	{
        if (Oyna) 
		{
			renderer.material.color = Color.white;
		}
		else if (BolumSec) 
		{
			renderer.material.color = Color.white;
		}
		else if (Kontroller) 
		{
			renderer.material.color = Color.white;
		}
		else if (Jenerik) 
		{
			renderer.material.color = Color.white;
		} 
		else if (Cikis) 
		{
			renderer.material.color = Color.white;
		}
    }
	void OnMouseDown() 
	{
		audio.clip = SecimBasSes;
		audio.Play();
		
        if (Oyna) 
		{
			Application.LoadLevel("Seviye 1");
		}
		else if (BolumSec) 
		{
			RotateCameraBolumSec();
		}
		else if (Kontroller) 
		{
			RotateCameraKontroller();
		}
		else if (Jenerik) 
		{
			RotateCameraJenerik();
		} 
		else if (Cikis) 
		{
			Application.Quit();
		}
    }
	
	void RotateCameraBolumSec()
	{
		kamera.GetComponent<YumusakGecis>().target = bolumSec.transform;
	}
	void RotateCameraKontroller()
	{
		kamera.GetComponent<YumusakGecis>().target = kontroller.transform;
	}
	void RotateCameraJenerik()
	{
		kamera.GetComponent<YumusakGecis>().target = jenerik.transform;
	}
}
