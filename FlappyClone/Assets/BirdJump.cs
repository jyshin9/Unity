using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour //MonoBehaviour를 상속받음
{
    Rigidbody2D rb; //Rigidbody2D(클래스)를 감당할 수 있는(?) rb라는 박스 생성
    public float jumpPower;
    public float SuperTime;
    public Move moveScript; //Move 스크립트의 참조를 저장할 변수

    // Start is called before the first frame update 최초 한번
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Rigidbody2D라는 component를 가져와서 rb에 담겠다
    }

    // Update is called once per frame 매 프레임마다
    void Update()
    {
        //매 프레임마다 검사
        if (Input.GetMouseButtonDown(0)) //마우스왼쪽(0)을 눌렀을 때(GetMouseButtonDown) or 터치했을 때
        {
            rb.velocity = Vector2.up * jumpPower; //(0,1*jumpPower), Vector2.up: (0,1)
        }
    }

    private bool isFrozen = false;

    public void OnCollisionEnter2D(Collision2D other)
    { //collision끼리 부딪혔을 때
        if (other.gameObject.tag == "obstacle")
        {
            if (Score.score > Score.bestScore)
            {
                Score.bestScore = Score.score;
            }
            SceneManager.LoadScene("GameOverScene"); //GameOverScene으로 넘어감
        }
        if (other.gameObject.tag == "Apple")
        { //apple 먹었을 시
            if (!isFrozen) //중력고정
            {
                StartCoroutine(FreezeObject());
            }
            StartCoroutine(SuperMode()); //무적모드
            Destroy(other.gameObject); //아이템 삭제
            //이동 속도 증가
            moveScript.speed = 10.0f;
        }
    }

    public IEnumerator FreezeObject()
    {
        isFrozen = true;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }

        //일정 시간 동안 고정
        yield return new WaitForSeconds(SuperTime);

        //고정 해제
        if (rb != null)
        {
            rb.isKinematic = false;
        }
        isFrozen = false;
    }

    IEnumerator SuperMode()
    { //StartCoroutine의 본체
        //this는 이 BirdJump 스크립트를 가지고 있는 오브젝트 == Bird를 뜻함.
        this.gameObject.layer = 7; //super layer로 변경
        GetComponent<SpriteRenderer>().color = Color.yellow;
        yield return new WaitForSeconds(SuperTime);
        this.gameObject.layer = 0; //원래대로 변경
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
