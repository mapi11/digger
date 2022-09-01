using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;

public class GameManagerScript : MonoBehaviour
{
    [HideInInspector]
    [SerializeField] private GameObject _goldSpawner;
    [HideInInspector]
    [SerializeField] private GameObject _gold;
    [HideInInspector]
    public int _Int;
    [HideInInspector]
    public bool _goldIsSpawned;
    private GameObject[] _GoldArray = new GameObject[0];

    public int _clicks;
    public bool _cantClick;


    TakeGoldScript _takeGold;

    private void Update()
    {
        _GoldArray = GameObject.FindGameObjectsWithTag("Gold");
    }

    private void Start()
    {
        _takeGold = FindObjectOfType<TakeGoldScript>();

        _Int = Random.Range(0, 8);

    }

    public void PanelClick()
    {
        if (_cantClick == false)
        {
            if (_GoldArray.Length <= 0)
            {
                if (_Int == 0)
                {
                    Debug.Log("Gold");
                    Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);

                    Click();

                    _goldIsSpawned = true;
                }
                else
                {
                    Debug.Log("Nope");
                    Click();

                    _clicks++;
                }
            }
        }
    }

    public void Click()
    {
        _Int = Random.Range(0, 8);

        if (_clicks == 0)
        {
            Debug.Log("1 click");
        }
        if (_clicks == 1)
        {
            Debug.Log("2 click");
        }
        if (_clicks == 2)
        {
            Debug.Log("cantClick");
            _cantClick = true;
        }
    }

    public void ChangePlane()
    {

    }
}

