using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingletonTestDlg : MonoBehaviour
{
    [SerializeField] Text m_txtResult;
    [SerializeField] Button m_btnOK;
    [SerializeField] Button m_btnClear;

    void Start()
    {
        m_btnOK.onClick.AddListener(OnClicked_OK);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
    }

    void OnClicked_OK()
    {
        GameManager1.Inst().m_score = 1000;
        m_txtResult.text = $"{GameManager1.Inst().m_score}";
    }
    void OnClicked_Clear()
    {
        m_txtResult.text = string.Empty;
    }
}
