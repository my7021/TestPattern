using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DelegateTest2 : MonoBehaviour
{
    [SerializeField]
    TextItem[] m_textItems = new TextItem[0];
    [SerializeField]
    Text m_txtResult;
    [SerializeField]
    Button m_btnOK;
    [SerializeField]
    Button m_btnClear;

    int selectIdx = -1;

    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        for (int i = 0; i < m_textItems.Length; i++)
        {
            m_textItems[i].AddListner(OnClickedTextItem);
        }            
    }

    void OnClickedTextItem(TextItem textItem, bool isSelect)
    {
        for (int i = 0; i < m_textItems.Length; i++)
        {
            m_textItems[i].SetColor(false);
        }
        textItem.SetColor(true);
        m_txtResult.text = $"{textItem.m_text.text}";
    }
}
