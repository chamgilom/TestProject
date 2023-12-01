using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()//초기화 1
    {
        Debug.Log("초기화 1");
    }
    // Start is called before the first frame update
    void Start()// 초기화 2
    {
        Debug.Log("초기화 2");
    }
    private void FixedUpdate()//물리연산 끝나고 호출
    {

    }
        // Update is called once per frame
    void Update()// 매 1프레임마다 호출
    {

    }
    private void LateUpdate()//위에 애들 다 끝나고 호출
    {
        
    }
    private void OnEnable()//게임오브젝트가 켜질때
    {
        Debug.Log("게임 오브젝트 켜짐");
    }
    private void OnDisable()//게임오브젝트가 꺼질때
    {
        Debug.Log("게임 오브젝트 꺼짐");
    }
}
