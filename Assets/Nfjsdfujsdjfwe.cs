using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Nfjsdfujsdjfwe : MonoBehaviour
{

    private void Start()
    {
        Hgfdnrteerwerwr();
    }

    [SerializeField] private List<Jurweursdfsdf> _urweurwueeruw;
    private int _fjsfjejrew = 1;

    private int _rueurwuer;

    [SerializeField] private TMP_Text _kkhkgfkhf;

    private void Update()
    {
        _kkhkgfkhf.text = $"Level {_rueurwuer}";
    }

    private void Hgfdnrteerwerwr()
    {
        _fjsfjejrew = PlayerPrefs.GetInt("CurrentLevel");
        if (_fjsfjejrew <= 0)
        {
            _fjsfjejrew = 1;
        }
        
        for (int sdfsd = 0; sdfsd < _fjsfjejrew; sdfsd++)
        {
            _urweurwueeruw[sdfsd].Jrwerkwkfksdf();
            _urweurwueeruw[sdfsd].Oirwirwirisdf += Tewrkrwkerksdf;
        }

        foreach (var fsdfqwer in _urweurwueeruw)
        {
            fsdfqwer.Oirwirwirisdf += Tewrkrwkerksdf;
        }
    }

    private void OnDestroy()
    {
        foreach (var fsdfsf in _urweurwueeruw)
        {
            fsdfsf.Oirwirwirisdf -= Tewrkrwkerksdf;
        }
    }

    public void Ukfsdkfskdfdfd()
    {
        if (_fjsfjejrew == _rueurwuer)
        {
            _urweurwueeruw[_fjsfjejrew].Jrwerkwkfksdf();
            _fjsfjejrew++;
        }
        PlayerPrefs.SetInt($"CurrentLevel", _fjsfjejrew);
    }

    public void Njgfsdjgjdfjgd()
    {
        PlayerPrefs.SetInt($"CurrentLevel", 0);
    }

    private void Tewrkrwkerksdf(int gdfgdfgdfg)
    {
        _rueurwuer = gdfgdfgdfg;
    }
}
