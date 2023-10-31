using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score
{
    public int m_score = 0;
    public static int sumScore = 0;

    public Score(int score)
    {
        m_score = score;
        sumScore += score;
    }
}

public class StaticTestDlg : MonoBehaviour
{
    [SerializeField] Text m_txtResult;
    [SerializeField] Button m_btnOK;
    [SerializeField] Button m_btnClear;

    void Start()
    {
        m_btnOK.onClick.AddListener(OnClicked_OK);
        m_btnClear.onClick.AddListener (OnClicked_Clear);
    }
    
    void OnClicked_OK()
    {
        Clear();
        Score Kim = new Score(90);
        PrintText(Kim.m_score);
        Score Park = new Score(80);
        PrintText(Park.m_score);
        Score Moon = new Score(95);
        PrintText(Moon.m_score);
    }
    void PrintText(int score)
    {
        m_txtResult.text += $"Score = {score}, Total = {Score.sumScore}\n";
    }
    void OnClicked_Clear()
    {
        Clear();
    }
    void Clear()
    {
        Score.sumScore = 0;
        m_txtResult.text = string.Empty;
    }
}
