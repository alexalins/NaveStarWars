using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
    public GameObject navePrefab; //Objeto Spawnar
    public float rateSpawn; // intervalo de spawn
    public float currentTime; //variavel de tempo
    private int posicao;
    private float x;
    public float posA;
    public float posB;
    public float posC;
    public float posD;
    private bool a;

    // Use this for initialization
    void Start () {
        currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpawn)
        {
            currentTime = 0;
            posicao = Random.Range(1,100);
            Debug.Log(posicao);
      
            if(posicao < 25)// maior q 50 aparece no alto
            {
                x = posA;//-7.46

            }
            else if (posicao > 25 && posicao <=50 )
            {
                x = posB;//-2.59f
            }
            else if(posicao > 50 && posicao <= 75)
            {
                x = posC;//2.59f
            }
            else
            {
                x = posD;//7.46
            }

            if (Player.pontos % 2 == 0 && a == false) //aumenta o spawn pra aparecer mais
            {
                a = true;
                rateSpawn -= 2;
                Debug.Log("mais");
            }

            GameObject tempPrefab = Instantiate(navePrefab) as GameObject; // colocando o spawn
            tempPrefab.transform.position = new Vector3(x, transform.position.y, tempPrefab.transform.position.z);
        }
	}
}
