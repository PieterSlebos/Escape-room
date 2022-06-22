using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadFloor : MonoBehaviour

{
    private GameControler gameControler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("werkt");
            SceneManager.LoadScene("Scene_Lobby");
            gameControler.coinsCollected = 0;


        }
    }
}
