using UnityEngine;
using System.Collections;

public class Forov : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target1;
	public Transform target2;
	// Update is called once per frame
	void Update () 
	{
		if (target1&&target2)
		{

			if(target1.position.x>target2.position.x)
			{
				Vector3 point = camera.WorldToViewportPoint(target1.position);
				Vector3 delta = target1.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
				Vector3 destination = transform.position + delta/2;

				destination = new Vector3(destination.x,(destination.y), destination.z);
			
				destination.y = (target1.position.y + target2.position.y) / 2; 
				transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			}
			else{
				Vector3 point = camera.WorldToViewportPoint(target2.position);
				Vector3 delta = target2.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
				Vector3 destination = transform.position + delta;


				destination.y = (target1.position.y + target2.position.y) / 2; 
				transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			}
		}
		
	}
}