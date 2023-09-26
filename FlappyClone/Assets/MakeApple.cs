using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeApple : MonoBehaviour
{
    public GameObject Apple;
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
            GameObject newapple = Instantiate(Apple); //apple을 찍어냄
            newapple.transform.position = new Vector3(5, Random.Range(-2.0f, 4.0f), 0);
            timer = 0; //timer 초기화
            if (newapple != null){
                Destroy(newapple, 5.0f);
            }
        }
    }
}
