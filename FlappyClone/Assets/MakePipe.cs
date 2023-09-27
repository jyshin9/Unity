using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //timer가 1이 되는 순간: 1초가 흐른 것

        if (timer > timediff)
        { // 1초가 지났을 때
            GameObject newpipe = Instantiate(pipe); //pipe를 찍어냄
            newpipe.transform.position = new Vector3(5, Random.Range(-2.5f, 4.5f), 0);
            timer = 0; //timer 초기화
            if(newpipe!=null){
                Destroy(newpipe, 5.0f); //생성했던 파이프 삭제-> 메모리 관리 가능
            }
        }
    }
}
