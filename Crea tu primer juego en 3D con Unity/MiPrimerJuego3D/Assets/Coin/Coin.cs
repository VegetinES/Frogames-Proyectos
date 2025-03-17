using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int cointCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        Coin.cointCount++;
        Debug.Log("El juego ha comenzado y hay " + Coin.cointCount + " monedas");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Estamos en el update");
    }

    // Cuando el trigger que tiene la moneda, otro objeto entra dentro
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Coin.cointCount--;
            
            Debug.Log(other.gameObject.tag + " ha colisionado con " + this.gameObject.name);
            Debug.Log(other.gameObject.tag + " ha recogido una moneda y ahora quedan " + Coin.cointCount + " monedas");

            if (Coin.cointCount == 0)
            {
                Debug.Log("El juego ha terminado");
                
                GameObject gameManager = GameObject.Find("GameManager");
                
                Destroy(gameManager);
                
                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach (GameObject firework in fireworksSystem)
                {
                    firework.GetComponent<ParticleSystem>().Play();
                }
            }
            
            Destroy(this.gameObject); //haciendo referencia a que se elimina la moneda
        }
        
        // other.gameObject.name = "Jugador"; // Para establecer un nombre al objeto, en este caso al FPSController, que se llame Jugador
    }
}
