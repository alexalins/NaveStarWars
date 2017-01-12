using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {

    public float speed;
    private Rigidbody2D rgd2; //referencia pra usar RigidBody

	// Update is called once per frame
	void Update () {
        rgd2 = GetComponent<Rigidbody2D>(); //pegando o rigidBody
        Movimento();
	}

    public void Movimento()
    {
        rgd2.velocity = transform.up * speed; //para o tiro subir no eixo Y com a velocidade
    }
}
