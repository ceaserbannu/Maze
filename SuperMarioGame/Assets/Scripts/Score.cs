using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static Score _score;
    private Score()
    {

    }

    private int _points;

    public static Score GetScore()
    {
        if (_score == null)
        {
            _score = new Score();
        }
        return _score;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void AddPoints(int points = 2)
    {
        _points += points;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}