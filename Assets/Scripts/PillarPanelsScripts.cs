using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarPanelsScripts : MonoBehaviour
{
    [SerializeField] private int[] _panelInt;                                                       //Old script
    [SerializeField] private GameObject[] _panel;
    [SerializeField] private GameObject[] _canvas;

    [SerializeField] private GameObject _goldSpawner;
    [SerializeField] private GameObject _gold;

    private int _numberOfBlades;

    private int a = 0;

    TakeGoldScript _goldScript;

    public bool _GoldIsSpawned;

    private void Start()
    {
        _goldScript = FindObjectOfType<TakeGoldScript>();

        for (int i = 0; i < _panel.Length; i++)
        {
            _panelInt[i] = Random.Range(0, 8);
        }
    }

    public void ClickUp()
    {

        if (_panelInt[a] != 0)
        {
            Destroy(_panel[a]);
            _canvas[a + 1].SetActive(true);

            a++;
            if (_panelInt[a] == 0)
            {
                Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);

                _canvas[a].SetActive(false);

                a++;
            }
        }
    }
}