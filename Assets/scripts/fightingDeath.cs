﻿using UnityEngine;
using System.Collections;

public class fightingDeath : MonoBehaviour 
{

	public int hp = 2;

		void OnTriggerEnter2D(Collider2D other)
			
			
		{

			if(other.gameObject.tag == "quill")
				
				
			{
				
			hp--;
				
			}
		}

	void Update ()
	{
		if (hp == 0)
		{
			DestroyObject(gameObject);
			currentScore.Score += 1000;
		}
	}

	public void OnMoveFinished()
	{
		StartCoroutine(waitAndRestart());
	}

	IEnumerator waitAndRestart()
	{
		yield return new WaitForSeconds(1f);
		GetComponent<iTweenEvent>().Play();
	}

}
	
	

