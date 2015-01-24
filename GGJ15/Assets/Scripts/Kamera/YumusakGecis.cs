using UnityEngine;
using System.Collections;

public class YumusakGecis : MonoBehaviour 
{
public Transform target;
public float yumusatma= 6.0f;
public bool yumusat= true;

	void  Start ()
	{
   		if (rigidbody)
		{
			rigidbody.freezeRotation = true;
		}
	}
	
	void  LateUpdate ()
	{
		if (target) 
		{
			if (yumusat)
			{  
				Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * yumusatma);
			}
			else
			{
			    transform.LookAt(target);
			}
		}
	}
}