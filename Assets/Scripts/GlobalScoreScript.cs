using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalScoreScript : MonoBehaviour
{
    [HideInInspector]
    public int _score = 0;
    //[HideInInspector]
    public int _blades = 20;

    [SerializeField] private TextMeshProUGUI _txtScore;
    [SerializeField] private TextMeshProUGUI _txtBlades;

    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _LooseWindow;
    [SerializeField] private GameObject _WinWindow;

    private void Start()
    {
        _parent = GameObject.Find("Main canvas");
    }

    private void Update()
    {
        _txtBlades.text = _blades.ToString("Blades:" + _blades); // Никак не могу понять почему при десятичных числах первая цифа двоится при выводе именный в этой переменной
        _txtScore.text = _score.ToString("Score:" + _score);
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
