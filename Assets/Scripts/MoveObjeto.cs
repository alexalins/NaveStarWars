using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjeto : MonoBehaviour {

    public float speed;
    private float y;
    public GameObject Nave;

	// Use this for initialization
	void Start () {
        Nave  = GameObject.Find("NaveVermelha") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        // faz o objeto andar mudando o Y
        y = transform.position.y;
        y += speed + Time.deltaTime;

        transform.position = new Vector3(transform.position.x,y, transform.position.z);
	}
}
