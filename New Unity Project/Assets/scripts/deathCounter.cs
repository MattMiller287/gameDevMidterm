using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathCounter : MonoBehaviour {

	public static int deaths;
	Text text;

	void Awake()
	{
		text = GetComponent <Text> ();
		deaths = 0;
	}

	void Update()
	{
		text.text = "Deaths: " + deaths;
	}


}
