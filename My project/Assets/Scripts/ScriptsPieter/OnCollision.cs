using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnCollision : MonoBehaviour
{
    public List<Image> UIImages = new List<Image>();

    public float speed = 1;
    public int maxHealth = 100;
    public int currentHealth;
    private bool FadedIn;

    public Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        FadedIn = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (FadedIn)
        {
            StartCoroutine(FadeOut());
            FadedIn = false;
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
            StartCoroutine(FadeIn());
            
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("Scene_Lobby");
        }
    }

    IEnumerator FadeIn()
    {
        float alpha = UIImages[0].color.a;

        while(alpha < 1)
        {
            alpha += Time.deltaTime * speed;
            for (int i = 0; i < UIImages.Count; i++)
            {
                UIImages[i].color = new Color(UIImages[i].color.r, UIImages[i].color.g, UIImages[i].color.b, alpha);

            }

            yield return null;
        }
        FadedIn = true;
        print(FadedIn);



        yield return null;
    }
    IEnumerator FadeOut()
    {
        float alpha = UIImages[0].color.a;

        while (alpha > 0)
        {
            alpha -= Time.deltaTime * speed;
            for (int i = 0; i < UIImages.Count; i++)
            {
                UIImages[i].color = new Color(UIImages[i].color.r, UIImages[i].color.g, UIImages[i].color.b, alpha);
            }

            yield return null;
        }



        yield return null;
    }
}
