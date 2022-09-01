using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGoldScript : MonoBehaviour
{
    GlobalScoreScript _globalScore;
    GameManagerScript _gameManager;

    public bool _GoldIsDestroyed;

    private void Start()
    {
        _globalScore = FindObjectOfType<GlobalScoreScript>();
        _gameManager = FindObjectOfType<GameManagerScript>();
    }

    public void TakeTheGold()
    {
        _gameManager.Click();
        Destroy(gameObject);

        _globalScore._score++;

        if (_globalScore._score >= 3)
        {
            _globalScore.Win();
        }
    }
}
