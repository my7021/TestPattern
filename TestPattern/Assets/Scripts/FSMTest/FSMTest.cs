using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSMTest : MonoBehaviour
{
    [SerializeField] Text m_txtResult;
    [SerializeField] Text m_txtMonster;
    [SerializeField] Text m_txtTime;
    [SerializeField] Button m_btnStart;
    [SerializeField] Button m_btnStop;
    [SerializeField] Button m_btnAttack;

    bool isStart = false;
    bool isAttack = false;
    float m_time = 20;
    int m_monsterHP = 100;

    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
        m_btnAttack.onClick.AddListener (OnClicked_Attack);
    }

    void OnClicked_Start()
    {
        isStart = true;
        isAttack = false;
        m_txtResult.text = "Ready";
        Initialize();
    }
    void OnClicked_Stop()
    {
        isStart = false;
        Initialize();
    }
    void OnClicked_Attack()
    {
        if(isStart && isAttack)
            m_monsterHP -= 10;
    }

    void Initialize()
    {
        m_time = 20;
        m_monsterHP = 100;
    }

    void Update()
    {
        if(isStart)
        {
            StateCheck();
            m_time -= Time.deltaTime;
            if(m_time <= 19)
            {
                isAttack = true;
                m_txtResult.text = "Game";
            }
            m_txtTime.text = $"{m_time:0.0}";
            m_txtMonster.text = $"Monster HP = {m_monsterHP}";
        }

        StateCheck();
    }
    void StateCheck()
    {
        if(m_monsterHP <= 0)
        {
            isStart = false;
            m_txtResult.text = "Result (½Â¸®)";
        }
        if (m_time <= 0)
        {
            isStart = false;
            m_txtResult.text = "Result (ÆÐ¹è)";
        }
    }
}
