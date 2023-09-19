using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour //MonoBehaviour를 상속받음
{
    Rigidbody2D rb; //Rigidbody2D(클래스)를 감당할 수 있는(?) rb라는 박스 생성
    public float jumpPower;

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
}
