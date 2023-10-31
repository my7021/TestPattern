using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextItem : MonoBehaviour
{
    public delegate void DelegateFunc(TextItem kItem, bool bSelect);
    public DelegateFunc OnSelectedFunc = null;

    [SerializeField] Button m_btn;
    public Text m_text;
    Image m_Image;

    private void Awake()
    {
        m_Image = GetComponent<Image>();                             
    }

    void Start()
    {
        m_btn.onClick.AddListener(OnClickEnter);
    }

    public void OnClickEnter()
    {
        if (OnSelectedFunc != null)
            OnSelectedFunc(this, true);
    }

    public void AddListner(DelegateFunc delegateFunc)
    {
        OnSelectedFunc = new DelegateFunc(delegateFunc);
    }

    public void SetColor(bool bSelect)
    {
        if (bSelect)
            m_Image.color = Color.green;
        else
            m_Image.color = Color.white;
    }
}

