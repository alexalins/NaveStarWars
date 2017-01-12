using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iminigos : MonoBehaviour {
    private float y;
    public float speed;
    private bool pontuado;
    private bool a;
    private int numP;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        y = transform.position.y;
        y += speed - Time.deltaTime;
        transform.position = new Vector3( transform.position.x,y, transform.position.z);
        y = transform.position.y;
  
        if (y < -3.5f && pontuado == false) //se a nave passar a vermelha perd 1 vida
        {
            pontuado = true;
            Player.vida--;
        }

        if (Player.pontos % 2 == 0 && a == false) //aumenta velocidade de uns
        {
            a = true;
            speed -= 0.025f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Shoot" && pontuado == false) //destroi e ganha ponto
        {
            pontuado = true;
            Player.pontos++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Nave" )//se bater morre
        {
            Debug.Log("bateu");
            Application.LoadLevel("game_over");
            PlayerPrefs.SetInt("pontos", Player.pontos);
            if (Player.pontos > PlayerPrefs.GetInt("recorde"))//ver se eh maior q o recorde
            {
                PlayerPrefs.SetInt("recorde", Player.pontos);
            }

        }
        if (Player.vida == 0)// se zerar a vida morre
        {
            Application.LoadLevel("game_over");
            PlayerPrefs.SetInt("pontos", Player.pontos);
            if (Player.pontos > PlayerPrefs.GetInt("recorde"))//ver se eh maior q o recorde
            {
                PlayerPrefs.SetInt("recorde", Player.pontos);
            }
        }
    }


}
