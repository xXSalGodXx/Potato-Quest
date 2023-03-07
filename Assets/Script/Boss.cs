using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int lives = 3;
    public int range;

    public float timeInvincible = 1.5f;
    float invincibleTimer;
    bool isInvincible;

    public float timerSmall = 1;
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
        //small fireball
        if (timerSmall > 0)
        {
            timerSmall -= Time.deltaTime;
        }

        if (timerSmall <= 0)
        {
            LaunchSmall();
            timerSmall = 1.5f;
        }
        //big fireball
        if (timerBig > 0)
        {
            timerBig -= Time.deltaTime;
        }

        if (timerBig <= 0)
        {
            LaunchBig();
            timerBig = 3f;
        }


        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }

    void LaunchSmall()
    {
        GameObject sFireBall = Instantiate(smallFireBall, transform.position, transform.rotation);
        sFireBall.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3 (300, Random.Range(-range,range), 0));
    }
    void LaunchBig()
    {
        GameObject bFireBall = Instantiate(bigFireBall, transform.position, transform.rotation);
        bFireBall.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3 (300, Random.Range(-range,range), 0));
    }
}
