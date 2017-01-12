using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class FronteiraLimite
{   // ate onde a nave vai
    public float maxX, minX;
}

public class Player : MonoBehaviour {

    public float speed;
    public FronteiraLimite fromLiment;
    private Rigidbody2D rgd2;
    public Transform prefabsShoot;
    public GameObject prefabPlayDeath;
    public float TimeShoot;
    private float currentTimeShoot;
    public Transform mira; // para colocar onde o tiro sai

    //pontuacao
    
    public static int pontos;
    public UnityEngine.UI.Text txtPontos;
    public static int vida;
    public UnityEngine.UI.Text txtVida;

    // Use this for initialization
    void Start () {
        pontos = 0;
        vida = 3;
        PlayerPrefs.SetInt("pontos", pontos);
        PlayerPrefs.SetInt("vida", vida);
        rgd2 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        txtPontos.text = pontos.ToString();
        txtVida.text = vida.ToString();
        Movimento();
        currentTimeShoot += Time.deltaTime;
        Shooting();

    }

    public void Movimento()
    {
        //limites no horizontal
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 newMovimet = new Vector3(horizontal, 0.0f, 0.0f);

        rgd2.velocity = newMovimet * speed;
        rgd2.position = new Vector3(Mathf.Clamp(rgd2.position.x, fromLiment.minX, fromLiment.maxX), rgd2.position.y, 0.0f);
    }

    //atirando
    public void Shooting()
    {
        if(currentTimeShoot >= TimeShoot && Input.GetButtonDown("Tiro"))
        {
            Instantiate(prefabsShoot, mira.position, transform.rotation);
            currentTimeShoot = 0;
        }
    }
}
