using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()//�ʱ�ȭ 1
    {
        Debug.Log("�ʱ�ȭ 1");
    }
    // Start is called before the first frame update
    void Start()// �ʱ�ȭ 2
    {
        Debug.Log("�ʱ�ȭ 2");
    }
    private void FixedUpdate()//�������� ������ ȣ��
    {

    }
        // Update is called once per frame
    void Update()// �� 1�����Ӹ��� ȣ��
    {

    }
    private void LateUpdate()//���� �ֵ� �� ������ ȣ��
    {
        
    }
    private void OnEnable()//���ӿ�����Ʈ�� ������
    {
        Debug.Log("���� ������Ʈ ����");
    }
    private void OnDisable()//���ӿ�����Ʈ�� ������
    {
        Debug.Log("���� ������Ʈ ����");
    }
}
