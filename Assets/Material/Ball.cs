using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Rigidbody 변수
    Rigidbody rb;
    Score scoreManager;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        scoreManager = FindAnyObjectByType<Score>();

        // scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        // 공이 정지해 있을 경우 깨우기
        if (rb.IsSleeping())
        {
            rb.WakeUp();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        string myTag = this.gameObject.tag;

        if (collision.gameObject.tag == "redBoard")
        {
            //get my tag
            

            if(myTag == "Ball")
            {
                
                scoreManager.AddScore(1);
                Debug.Log ("1점 획득");

            }
            

            Destroy(this.gameObject);
           
        }
        else if (collision.gameObject.tag == "greenBoard")
        {
            if(myTag == "Ball")
            {
                scoreManager.AddScore(2);
                Debug.Log ("2점 획득");
            }
            
            

            Destroy(this.gameObject);
        }

        

        // scoreManager.RemoveSphere(this.gameObject);
    }

}

