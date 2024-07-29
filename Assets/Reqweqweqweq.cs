using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Reqweqweqweq : MonoBehaviour
{

    [SerializeField] private AudioSource _euqweuasudasd;

    [SerializeField] private AudioSource _dfsdnfjewjer;

    private bool _iqieiqiasdasd = true;
    
    private bool _eqwetqteqtetqwe = true;
    
    public Text craftingResultText;
    private Dictionary<string, int> resources = new Dictionary<string, int>();
    private Dictionary<string, string[]> craftingRecipes = new Dictionary<string, string[]>();

    // Quest system variables.
    public Text questText;
    private Queue<string> questQueue = new Queue<string>();
    private bool questActive = false;

    // Dynamic object interaction variables.
    public Text interactionText;
    private bool nearInteractable = false;

    [SerializeField] private Slider _nxnvxnbncvbfg;
    [SerializeField] private Slider _tuueruteurt;


    private void Update()
    {
        _euqweuasudasd.volume = _nxnvxnbncvbfg.value;
        _dfsdnfjewjer.volume = _tuueruteurt.value;
        
        questQueue.Enqueue("fsdfsdfs");
    }

    public void Dsdasdadcsdfsdf(AudioClip fjsfhsdhghf)
    {
        _dfsdnfjewjer.clip = fjsfhsdhghf;
        questQueue.Enqueue("fsedferwerwer");


        _dfsdnfjewjer.Play();
    }
}
