using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollissionCoin : MonoBehaviour
{
    private GameControler gameControler;

    // Start is called before the first frame update
    void Start()
    {
        gameControler = GameObject.FindObjectOfType<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
   

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gameControler.coinsCollected += 1;
            
        }
    }

}
