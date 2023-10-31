using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1
{
    static GameManager1 _inst = null;
    public static GameManager1 Inst()
    {
        if(_inst == null)
            _inst = new GameManager1();
        return _inst;
    }

    public int m_score = 100;
}

public class Test
{
    public void Initialize()
    {
        GameManager1.Inst().m_score = 200;
        Debug.Log($"{GameManager1.Inst().m_score}");
    }
}

public class GameManager2
{

    static GameManager2 _instance = null;
    public static GameManager2 Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameManager2();
            return _instance;
        }
    }
}

public class GameManager3 : MonoBehaviour
{
    static GameManager3 _inst = null;
    public static GameManager3 Inst
    {
        get
        {
            if(_inst == null)
            {
                GameObject go = new GameObject("Singleton GameManager");
                _inst = go.AddComponent<GameManager3>();
                DontDestroyOnLoad(go);
            }
            return _inst;
        }
    }

    int m_score = 100;

    public int GetScore() { return m_score; }
    public void SetScore(int score) { m_score = score;}

    public int score
    {
        get { return m_score; }
        set { m_score = value; }
    }
}
