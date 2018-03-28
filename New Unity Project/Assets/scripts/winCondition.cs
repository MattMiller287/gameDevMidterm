using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour {

	public Text WinText;
	public GameObject gameOverPanel;

	void OnTriggerEnter(Collider other) 
	{
		gameOverPanel.SetActive (true);
	}
}
