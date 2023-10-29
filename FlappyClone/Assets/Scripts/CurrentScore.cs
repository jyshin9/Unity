using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Text 컴포넌트 속성을 가져옴
        GetComponent<Text>().text = "Score: " + Score.score.ToString();
    }
}

