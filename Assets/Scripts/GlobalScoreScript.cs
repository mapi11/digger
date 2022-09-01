using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GlobalScoreScript : MonoBehaviour
{
    public int _score = 0;
    public int _blades = 20;

    public bool _loose;
    public bool _win;

    //[SerializeField] private TextMeshProUGUI _txtScore;
    //[SerializeField] private TextMeshProUGUI _txtBlades;

    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _LooseWindow;
    [SerializeField] private GameObject _WinWindow;

    

    private void Start()
    {
        _parent = GameObject.Find("Main canvas");
    }

    private void Update()
    {
        //_txtSBlades.text = _blades.ToString("Blades: " + _blades);
        //_txtBlades.text = _blades.ToString("Blades: " + _blades);

        if (_score >= 3)
        {
            _win = true;
        }
        if (_blades <= 0)
        {
            _loose = true;
        }
    }

    public void Loose()
    {
        Instantiate(_LooseWindow, _parent.transform.position, _parent.transform.rotation, _parent.transform);
    }

    public void Win()
    {
        Instantiate(_WinWindow, _parent.transform.position, _parent.transform.rotation, _parent.transform);
    }
}
