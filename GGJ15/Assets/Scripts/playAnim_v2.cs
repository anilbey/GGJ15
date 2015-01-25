using UnityEngine;
using System.Collections;

public class playAnim_v2 : MonoBehaviour {

	public string parameter = "playAnim";
	public bool playOnClick, playOnCollision, playParent, playRandomly, playParentParent;
	public float rangeMin = 5f;
	public float rangeMax = 15f;
	private bool playOnce = true;


	void Start()
	{
		if(playRandomly && !playParent)
		{
			StopCoroutine("PlayWithDelay");
			StartCoroutine("PlayWithDelay");
		}
	}


	IEnumerator PlayWithDelay()
	{
		while(this.gameObject.activeSelf)
		{
			yield return new WaitForSeconds(Random.Range(rangeMin, rangeMax));
			PlayAnimation();
		}
	}

	void PlayAnimation()
	{
		if(playParent)
			this.transform.parent.GetComponent<Animator>().SetBool(parameter,true);
		else if (playParentParent)
		{
			this.transform.parent.parent.GetComponent<Animator>().SetBool(parameter,true);
			//print ("entered");
		}
		else
			this.GetComponent<Animator>().SetBool(parameter,true);

		Invoke("RevertParameter", 0.2f);
	}

	void RevertParameter()
	{
		if(playParent)
			this.transform.parent.GetComponent<Animator>().SetBool(parameter,false);
		else if(playParentParent)
			this.transform.parent.parent.GetComponent<Animator>().SetBool(parameter,false);
		else
			this.GetComponent<Animator>().SetBool(parameter,false);
	}


	void OnMouseDown()
	{

		if(playOnce && playOnClick)
		{
			PlayAnimation();
			playOnce = false;

		}
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if(playOnCollision)
			PlayAnimation();
	}

	void OnEnable()
	{
		if(playRandomly && !playParent)
		{
			StopCoroutine("PlayWithDelay");
			StartCoroutine("PlayWithDelay");
		}
	}

}
