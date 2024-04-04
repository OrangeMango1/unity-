using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject BallPrefab; // 볼 프리팹을 참조하기 위한 변수
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 코루틴 시작
        StartCoroutine(SpawnBalls());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBalls()
    {
        // 무한 루프 안에서 실행
        while (true)
        {
            GameObject ball;
            // 2초 기다림
            yield return new WaitForSeconds(2f);

            // 랜덤하게 공을 생성
            int random = Random.Range(0, 2);
            if (random == 0)
            {
                ball = Instantiate(BallPrefab, new Vector3(Random.Range(18, 23), 41, -11), Quaternion.identity); // 볼 프리팹을 생성하여 사용

                float addGravity = 2.0f;
                
                ball.GetComponent<Rigidbody>().AddForce(Vector3.down * addGravity, ForceMode.Impulse); // 생성된 볼에 Rigidbody와 Force 적용
                Debug.Log ("볼 생성");
            }
            
        }
    }
    public void AddScore(int n)
    {
        score += n;
        scoreText.text = "Score : " + score;
    }
}
