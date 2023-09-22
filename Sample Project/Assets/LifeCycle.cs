using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start(){
        Vector3 vec = new Vector3(0,0,0); //벡터 값
        //vec만큼 이동(Translate)
        transform.Translate(vec); //3차원
    }

    void Update(){
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime,
            0); //x축: 횡, y축: 종
        transform.Translate(vec);
    }

    //void Update(){
        //if (Input.anyKeyDown)
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        /*if(Input.GetKeyDown(KeyCode.Return)) //엔터키, GetKeyDown: 한번 누를 때마다
            Debug.Log("아이템을 구입하였습니다.");
        if(Input.GetKey(KeyCode.Return)) //왼쪽화살표, GetKey: 누르는 동안에
            Debug.Log("왼쪽으로 이동 중.");
        if(Input.GetKeyUp(KeyCode.Return)) //오른쪽화살표, GetKeyUp: 눌렀다 뗐을 때
            Debug.Log("오른쪽 이동을 멈추었습니다."); */

        /*if(Input.GetMouseButtonDown(0)) //0: 마우스 왼쪽 버튼
            Debug.Log("미사일 발사!");
        if(Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        if(Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");*/

        /*if(Input.GetButtonDown("Jump")) //Fire1 = jump = space, edit->Project settings->InputManager
            Debug.Log("점프!");
        if(Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        if(Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");*/
        
        /*if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..."
                +Input.GetAxisRaw("Horizontal"));
        }
        if(Input.GetButton("Vertical")){
            Debug.Log("종 이동 중..."
                +Input.GetAxisRaw("Vertical"));
        }*/
    //}
}

