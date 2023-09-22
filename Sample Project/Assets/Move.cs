using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//원하는 목적지(target)로 이동시키기
public class Move : MonoBehaviour
{
    Vector3 target =new Vector3(2, 1.5f, 0);

     void Update()
    {
        //1. MoveTowards(현재위치, 목표위치, 속도: 등속이동
        /*transform.position = 
            Vector3.MoveTowards(transform.position
                                , target, 2f);*/
        
        //2. SmoothDamp: 부드러운 이동
        /*Vector3 velo =new Vector3.zero;

        transform.position = 
            Vector3.SmoothDamp(transform.position
                                , target, ref velo, 0.1f);*/

        //3. Lerp: 선형보간 이동
        /*transform.position = 
            Vector3.Lerp(transform.position
                                , target, 0.05f); */

        //4. SLerp: 구면보간 이동, 포물선 이동, 호 이동
        transform.position =
            Vector3.Slerp(transform.position
                                , target, 0.05f);
    }
}
