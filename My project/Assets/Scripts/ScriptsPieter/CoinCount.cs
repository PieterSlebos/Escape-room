using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    public Text CoinCounter;
    int CoinsLeft;
   
    // Start is called before the first frame update
    private GameControler gameControler;
    void Start()
    {
        gameControler = GameObject.FindObjectOfType<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
        CoinsLeft = 10 - gameControler.coinsCollected;
        CoinCounter.text = "Coins left : " + CoinsLeft.ToString();
    }
   
}
