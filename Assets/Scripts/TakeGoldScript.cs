using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGoldScript : MonoBehaviour
{
    GlobalScoreScript _globalScore;

    public bool _GoldIsPicked;

    private void Start()
    {
        _globalScore = FindObjectOfType<GlobalScoreScript>();
    }

    public void TakeTheGold()
    {
        _GoldIsPicked = true;
        Destroy(gameObject);
        _globalScore._score++;
    }
}
