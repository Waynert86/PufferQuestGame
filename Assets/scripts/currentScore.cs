﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class currentScore : MonoBehaviour {

	public Text scoreText;
	public static int Score;



void Update ()
	{
		scoreText.text = "Score: " + Score;
		
	}
}
