﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    // para poder pegar o txt
    public UnityEngine.UI.Text pontos;
    public UnityEngine.UI.Text recorde;
    // Use this for initialization
    void Start () {
        pontos.text = PlayerPrefs.GetInt("pontos").ToString();
        recorde.text = PlayerPrefs.GetInt("recorde").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
