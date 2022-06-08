using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollissionCoin : MonoBehaviour
{
    int coinsCollected;
    public bool levelBallsSucceed;
    // Start is called before the first frame update
    void Start()
    {
        
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
            coinsCollected += 1;

            if (coinsCollected == 5)
            {
                SceneManager.LoadScene("Scene_Lobby");
                levelBallsSucceed = true;
            }
        }
    }
}
