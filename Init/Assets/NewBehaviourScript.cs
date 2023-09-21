using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //전역변수
    int health = 30;
    int level = 5;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Hello Unity!");

        //1. 변수
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        //2. 그룹형 변수
        string[] monsters = {"슬라임", "사막뱀", "악마"};
        int[] monsterlevel = new int[3];
        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterlevel[0]);
        Debug.Log(monsterlevel[1]);
        Debug.Log(monsterlevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0); //0: 지우고 싶은 아이템의 번지수

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]); //인덱스 오류

        //3. 연산자
        int exp = 1500;
        exp -= 10;
        level = exp/300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300); //%: 나머지 출력
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level >= 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?"+isEndTutorial);

        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + condition);

        //4. 키워드: 변수 이름으로도, 값으로도 사용할 수 없음
        //int float string bool new List

        //5. 조건문
        if(condition == "나쁨"){
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else{
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if(isBadCondition && items[0] == "생명물약30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if(isBadCondition && items[0] == "마나물약30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        string mosterAlarm;
        switch(monsters[1]){
            case "슬라임":
            case "사막뱀":
                mosterAlarm = "소형 몬스터가 출현!";
                break;
            case "악마":
                mosterAlarm = "중형 몬스터가 출현!";
                break;
            case "골렘":
                mosterAlarm = "대형 몬스터가 출현!";
                break;
            default:
                mosterAlarm = "??? 몬스터가 출현!";
                break;
        }

        while (health > 0){
            health --;
            if(health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else   
                Debug.Log("사망하였습니다.");

            if(health == 10){
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }
        
        for(int count = 0; count<10; count++){
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        for(int index = 0; index < monsters.Length; index++){
            Debug.Log("이 지역에 있는 몬스터: "+ monsters[index]);
        }

        foreach (string monster in monsters){
            //Debug.Log("이 지역에 있는 몬스터: " + monster);
        }

        Heal();

        for(int index=0; index < monsters.Length; index++){
            Debug.Log("용사는"+monsters[index]+"에게"+
                Battle(monsterlevel[index]));
        }

        //8.클래스
        Actor player = new Actor(); //인스턴스화: 정의된 클래스를 변수 초기화로 실체화
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");

        //상속: Player 클래스(자식)가 Actor 클래스(부모)를 상속받음.
        Player player2 = new Player(); //인스턴스화: 정의된 클래스를 변수 초기화로 실체화
        player2.id = 0;
        player2.name = "나법사";
        player2.title = "현명한";
        player2.strength = 2.4f;
        player2.weapon = "나무 지팡이";
        Debug.Log(player2.Talk());
        Debug.Log(player2.HasWeapon());

        player2.LevelUp();
        Debug.Log(player2.name + "의 레벨은" + player2.level + "입니다.");
        Debug.Log(player2.move());
    }

    //7. 함수(메소드)
    void Heal(){
        health += 10;
    }

    string Battle(int monsterLevel){
        string result;
        if(level>=monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }
}
