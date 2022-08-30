using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarPanelsScripts : MonoBehaviour
{
    public int[] _panelInt;
    public GameObject[] _panel;

    public GameObject _goldSpawner;
    public GameObject _gold;

    private void Start()
    {
        _panelInt[0] = Random.Range(0, 5);
        _panelInt[1] = Random.Range(0, 5);
        _panelInt[2] = Random.Range(0, 5);
    }

    public void ClickUp()
    {
        if (_panelInt[0] != 0)
        {
            Destroy(_panel[0]);
        }
        else
        {
            Debug.Log("Gold");
            Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);
        }
    }
    public void ClickMid()
    {
        if (_panelInt[1] != 0)
        {
            Destroy(_panel[1]);
        }
        else
        {
            Debug.Log("Gold");
            Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);
        }
    }
    public void ClickDown()
    {
        if (_panelInt[2] != 0)
        {
            Destroy(_panel[2]);
        }
        else
        {
            Debug.Log("Gold");
            Instantiate(_gold, _goldSpawner.transform.position, _goldSpawner.transform.rotation, _goldSpawner.transform);
        }
    }
}
