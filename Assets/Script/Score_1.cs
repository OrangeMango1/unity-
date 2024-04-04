using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/*public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject BallPrefab; // 볼 프리팹을 참조하기 위한 변수
    private int score = 0;

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

    private void OnTriggerEnter(Collider other)
    {
        // 플로어 2에 충돌한 경우
        if (gameObject.name == "Floor_2" && other.gameObject.CompareTag("Ball"))
        {
            score += 1;
            Debug.Log ("111");
        }
        // 플로어 1 또는 플로어 3에 충돌한 경우
        else if ((gameObject.name == "Floor_1" || gameObject.name == "Floor_3") && other.gameObject.CompareTag("Ball"))
        {
            score += 2;
            Debug.Log ("222");
        }

        // 점수를 업데이트하여 UI에 표시
        scoreText.text = "Score: " + score.ToString();
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
                ball.GetComponent<Rigidbody>().AddForce(Vector3.down * 2.0f, ForceMode.Impulse); // 생성된 볼에 Rigidbody와 Force 적용
            }
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

            }
            

            Destroy(this.gameObject);
           
        }
}
*/