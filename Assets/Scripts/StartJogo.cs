﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartJogo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("jogo");
        }
    }
}