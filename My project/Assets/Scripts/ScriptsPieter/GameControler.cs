using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    public GameObject ball;
    public Transform SpawnPoint;
    public GameObject coin;

    public bool levelBallsSucceed;
    public int coinsCollected;

    public bool LevelIdeSucceed;


    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (coinsCollected == 5 && !levelBallsSucceed)
        {
            SceneManager.LoadScene("Scene_Lobby");
            levelBallsSucceed = true;
        }
    }
}
