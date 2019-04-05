﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {


	Image timerBar;
	public float maxTime = 5f;
	float timeleft;
	public GameObject timesUpText;



	// Use this for initialization
	void Start () {
		timesUpText.SetActive (false);
		timerBar = GetComponent<Image> ();
		timeleft = maxTime;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeleft > 0) {
			timeleft -= Time.deltaTime;
			timerBar.fillAmount = timeleft / maxTime;
		} else {
			timesUpText.SetActive (true);
			Time.timeScale = 0;
		}
		
	}
}
