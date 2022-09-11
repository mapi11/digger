using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [HideInInspector]
    [SerializeField] private GameObject _goldSpawner;
    [HideInInspector]
    [SerializeField] private GameObject _gold;

    public int _Int;

    private GameObject[] _GoldArray = new GameObject[0];

    private int _clicks;
    private int _maxClicks = 2;
    private bool _cantClick;

    private bool _colorChange;

    [SerializeField] private Material[] _planeMaterial;
    [SerializeField] private GameObject _plane;

    TakeGoldScript _takeGold;
    GlobalScoreScript _globalScore;

    private void Update()
    {
        _GoldArray = GameObject.FindGameObjectsWithTag("Gold");
    }

    private void Start()
    {
        _takeGold = FindObjectOfType<TakeGoldScript>();
        _globalScore = FindObjectOfType<GlobalScoreScript>();

        //_globalScore._blades = 20;

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
                    //Debug.Log("Gold");
                    Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);

                    Click();
                }
                else
                {
                    //Debug.Log("Nope");
                    _colorChange = true;
                    Click();

                    _clicks++;

                    _globalScore._clicks--;

                    if (_globalScore._clicks <= 0)
                    {
                        _globalScore.Loose();
                    }
                }
            }
        }
    }

    public void Click()
    {
        _Int = Random.Range(0, 8);

        if (_clicks == 0 && _colorChange == true)
        {
            //Debug.Log("1 click");
            _plane.GetComponent<MeshRenderer>().material = _planeMaterial[0];
        }
        else if (_clicks == 1 && _colorChange == true)
        {
            //Debug.Log("2 clicks");
            _plane.GetComponent<MeshRenderer>().material = _planeMaterial[1];
        }
        else if (_clicks == _maxClicks && _colorChange == true)
        {
            //Debug.Log("can`t click");
            _plane.GetComponent<MeshRenderer>().material = _planeMaterial[2];
            _cantClick = true;
        }

        _colorChange = false;
    }
}

