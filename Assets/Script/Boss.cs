using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int lives = 3;

    public float timeInvincible = 1.5f;
    float invincibleTimer;
    bool isInvincible;

    public float timerSmall = 3;
    public float timerBig = 5;

    public GameObject smallFireBall;
    public GameObject bigFireBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            Destroy(gameObject);
        }

        if (timerSmall > 0)
        {
            timerSmall -= Time.deltaTime;
        }

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }
}
