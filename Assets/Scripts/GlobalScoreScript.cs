using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalScoreScript : MonoBehaviour
{
    [HideInInspector]
    public int _score;
    //[HideInInspector]
    public int _clicks;

    [SerializeField] private TextMeshProUGUI _txtScore;
    [SerializeField] private TextMeshProUGUI _txtBlades;

    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _LooseWindow;
    [SerializeField] private GameObject _WinWindow;

    private void Start()
    {
        _parent = GameObject.Find("Main canvas");

        _clicks = 20;
    }

    private void Update()
    {
        _txtBlades.text = "Clicks:" + _clicks;
        _txtScore.text = "Score:" + _score;
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
