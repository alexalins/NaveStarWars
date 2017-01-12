using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other)
    {   //quando o tiro passar do limite ele se destroi
        Destroy(other.gameObject);
    }
}
