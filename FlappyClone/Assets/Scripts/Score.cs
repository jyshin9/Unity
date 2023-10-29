using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //유니티엔진에 UI를 가져와서 사용

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; //점수가 누적되지 않음
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}

