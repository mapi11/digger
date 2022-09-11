using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsWindowScript : MonoBehaviour
{
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _settingsWindow;

    private void Start()
    {
        _parent = GameObject.Find("pMenuLeft");
    }

    public void Press()
    {
        Instantiate(_settingsWindow, _parent.transform.position, _parent.transform.rotation, _parent.transform);
    }

    public void Resume()
    {
        Destroy(_settingsWindow);
    }
}
