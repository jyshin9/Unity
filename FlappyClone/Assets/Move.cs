using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //(-1,0,0) 매시간마다 x축 방향으로 -1씩 이동, Time.deltaTime을 이용하여 fps보정
        transform.position += Vector3.left * test(speed) * Time.deltaTime;
    }

    int test(test){
        return test
    }
}
