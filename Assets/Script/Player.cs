using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 3.5f;
    int lives = 3;
    int score = 0;

    public float timeInvincible = 1.5f;
    float invincibleTimer;
    bool isInvincible;

    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            LoadScene("Menu");
        }

        if(score >= 3)
        {
            LoadScene("Menu");
        }
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
