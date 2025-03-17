using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 120f;
    private float countdown = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime representa el tiempo en segundos que ha pasado desde el último frame
        countdown -= Time.deltaTime;
        
        Debug.Log(countdown);

        if (countdown <= 0f)
        {
            Debug.Log("Se ha terminado el tiempo, has perdido!!!");

            Coin.cointCount = 0;
            
            SceneManager.LoadScene("MainScene");
        }
    }
}
