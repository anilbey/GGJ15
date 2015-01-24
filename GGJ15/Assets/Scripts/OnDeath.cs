using UnityEngine;
using System.Collections;

public class OnDeath : MonoBehaviour {

	private GameObject []checkpoints;
	public GameObject activePoint;
	
	
	public Transform player1;
	public Transform player2;


	public void CheckpointMgr() 
	{

		checkpoints = GameObject.FindGameObjectsWithTag("checkPoint");
		
		foreach (GameObject obj in checkpoints)
		{
			if (this.smallerPlayerPos() > obj.transform.position.x && obj.transform.position.x >= activePoint.transform.position.x)
				activePoint = obj;
		}
	
		
	}
	
	
	float smallerPlayerPos()
	{
		return ((player1.position.x < player2.position.x) ? player1.position.x : player2.position.x);
	}
		
		



	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Thorn")
		{
			Invoke("teleport",1);

		}

	}

	void teleport(){

		this.CheckpointMgr();
		//print (activePoint.transform.position.x);
		player1.position = activePoint.transform.position;
		player2.position = new Vector3(activePoint.transform.position.x + 3* ((Random.Range(0,4) % 2 ==1) ? -1 : 1), activePoint.transform.position.y, activePoint.transform.position.z);

	}

}
