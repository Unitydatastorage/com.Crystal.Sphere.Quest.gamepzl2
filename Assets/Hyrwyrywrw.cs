using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.XR;

public class Hyrwyrywrw : MonoBehaviour
{
    public LayerMask rwuerwuer;
    public float fhshfsdhgr = 1f;

    private Vector2 rtywerywyerw;
    private Vector2 eorworosdf;
    private List<GameObject> eqwueuqwusdas = new List<GameObject>();
    private List<Yrtwerysdfsdfsf> riweirwieriwer = new List<Yrtwerysdfsdfsf>();

    private bool gdfgdfsdf = false;

    [SerializeField] private Sprite _uteuteurt;
    [SerializeField] private Sprite _nbcvnbcnvbcvb;
    [SerializeField] private Sprite _riweriir;
    
    public float tieritert = 1f;
    public int nvbndgdfg = 10;
    public float adasdads = 0.1f;
    
    
    // Amplitude of the sine wave.
    public float amplitude = 1.0f;
    
    // Frequency of the sine wave.
    public float frequency = 1.0f;

    // Rotation speed.
    public float rotationSpeed = 100.0f;

    // Color change speed.
    public float colorChangeSpeed = 1.0f;

    // Initial position of the GameObject.
    private Vector3 initialPosition;

    // Renderer component of the GameObject.
    private Renderer objectRenderer;

    // Initial color of the GameObject.
    private Color initialColor;

    private List<GameObject> yutyrtyrty = new List<GameObject>();


    private GameObject _kdgkdfjkgdf;

    [SerializeField] private Rertegdfgd rertegdfgd;

    private Jgdfgdhtet _currentJgdfgdhtet;
    private GameObject riweirwieri;
    private GameObject gjdjfgjdg;
    private bool oyrtoyorhfgh;
    
    
    private bool cvxfdsfsdf = false;

    public bool jjghrtyrth;

    public bool Jjghrtyrth => jjghrtyrth;

    [SerializeField] private Iitweiteirt iitweiteirt;
    [SerializeField] private Reqweqweqweq reqweqweqweq;
    
    [SerializeField] private AudioClip _jfsjfsjdf;
    [SerializeField] private AudioClip _ppweroweor;

    [SerializeField] private AudioClip _eiqieqieias;
    

    private void OnEnable()
    {
        riweirwieriwer = new List<Yrtwerysdfsdfsf>();
        eqwueuqwusdas = new List<GameObject>();

        if (rertegdfgd.CellWerwyeryweyr != null)
        {
            foreach (var cell in rertegdfgd.CellWerwyeryweyr)
            {
                cell.GetComponent<SpriteRenderer>().sprite = _nbcvnbcnvbcvb;
            }
        }

        gdfgdfsdf = false;
        cvxfdsfsdf = false;
        jjghrtyrth = false;
        oyrtoyorhfgh = false;
        gjdjfgjdg = null;
        riweirwieri = null;

    }

    private void OnDisable()
    {
        riweirwieriwer.Clear();
        eqwueuqwusdas.Clear();
    }

    void Update()
    {
        if (jjghrtyrth || rertegdfgd.Sgdfsgfsgdf)
        {
            return;
        }

        if (!rertegdfgd.enabled)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Clear previous selection when starting a new selection
            gdfgdfsdf = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gdfgdfsdf = false;
            oyrtoyorhfgh = false;
            gjdjfgjdg = null;
            riweirwieri = null;
            _currentJgdfgdhtet = Jgdfgdhtet.Poerwerwer;
            Hfsherirwisdf();
        }
        
        if (gdfgdfsdf)
        {
            // During drag, perform raycast and update selection
            Uerueurufsdf();
        }
    }
    
    void Uerueurufsdf()
    {
        Vector2 hjghjgdfgdfg = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        initialPosition = transform.position;

        // Get the Renderer component.
        objectRenderer = GetComponent<Renderer>();

        // Store the initial color of the GameObject.
        if (objectRenderer != null)
        {
            initialColor = objectRenderer.material.color;
        }

        
        MoveInSinusoidalPattern();
        // Calculate start direction based on mouse movement
        var fdgdfgtrete = (Vector2)Input.mousePosition - hjghjgdfgdfg;
        fdgdfgtrete.Normalize();

        // Calculate perpendicular direction for "snake" pattern
        var mnbnmjghjghj = new Vector2(-fdgdfgtrete.y, fdgdfgtrete.x);
        
        RotateObject();

        for (int i = 0; i < nvbndgdfg; i++)
        {
            // Calculate offset for current ray
            var dgdgert = (i - (nvbndgdfg - 1) / 2f) * adasdads;

            // Calculate direction for current ray
            var cvbdfgdfgerte = fdgdfgtrete + dgdgert * mnbnmjghjghj;

            // Perform raycast
            var ggfdgdfg = Physics2D.Raycast(hjghjgdfgdfg, cvbdfgdfgerte, tieritert, rwuerwuer);

            if (ggfdgdfg.collider == null) continue;
            //if (_previousCollider != null)
            var fsdferwerw = ggfdgdfg.collider.gameObject;

            if (fsdferwerw == null)
            {
                return;
            }

            var sdfsdfsd = fsdferwerw.transform.localPosition;
            var hfghrtyrt = rertegdfgd.Vbcxbvbsdfs[(int)(sdfsdfsd.x / Urweirwoerw.YFHDSHFDH_RWEIRWIER), (int)(sdfsdfsd.y / Urweirwoerw.YFHDSHFDH_RWEIRWIER)];
            var werwfgdter = hfghrtyrt.jgdfgdhtet;

            if (gdfgdfsdf && !oyrtoyorhfgh)
            {
                riweirwieri = fsdferwerw;
                _currentJgdfgdhtet = werwfgdter;
                oyrtoyorhfgh = true;
            }
            
            ChangeColorOverTime();

            if (gjdjfgjdg != null)
            {
                var fdgrtetdfg = gjdjfgjdg.transform.localPosition;
                var hfghtyrty = Mathf.Abs(sdfsdfsd.x - fdgrtetdfg.x) + Mathf.Abs(sdfsdfsd.y - fdgrtetdfg.y) > 1;

                if (hfghtyrty)
                {
                    return;
                }
            }

            if (_currentJgdfgdhtet != Jgdfgdhtet.Poerwerwer && _currentJgdfgdhtet != werwfgdter)
            {
                return;
            }
                
            
            HandleUserInput();

            var trekrkwerk = 100f;
            // Add hit cell to selected cells if not already selected
            if (!eqwueuqwusdas.Contains(fsdferwerw))
            {
                eqwueuqwusdas.Add(fsdferwerw);
                riweirwieriwer.Add(hfghrtyrt);

                Yttiertieirrtie(fsdferwerw);
                gjdjfgjdg = fsdferwerw;
            }

            if (_kdgkdfjkgdf == fsdferwerw) continue;
            var teterte = 5f;
            _kdgkdfjkgdf = fsdferwerw;
        }
    }
    
    // Method to move the GameObject in a sinusoidal pattern.
    void MoveInSinusoidalPattern()
    {
        float newY = initialPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
    }

    // Method to rotate the GameObject.
    void RotateObject()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    // Method to change the color of the GameObject over time.
    void ChangeColorOverTime()
    {
        if (objectRenderer != null)
        {
            float colorOffset = Mathf.PingPong(Time.time * colorChangeSpeed, 1.0f);
            objectRenderer.material.color = Color.Lerp(initialColor, Color.red, colorOffset);
        }
    }

    // Method to handle user input.
    void HandleUserInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reset position to the initial position.
            transform.position = initialPosition;

            // Reset color to the initial color.
            if (objectRenderer != null)
            {
                objectRenderer.material.color = initialColor;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Print a message to the console.
            Debug.Log("Space key was pressed!");
        }
    }

    void Yttiertieirrtie(GameObject eqesdasd)
    {
        float werwerwer = 1f;
        int pepepqepqwep = 1;
        eqesdasd.GetComponent<SpriteRenderer>().sprite = _uteuteurt;
    }

    void Hfsherirwisdf()
    {
        var gfdgertwrwer = false;

        if (eqwueuqwusdas.Count == 0)
        {
            initialColor = new Color();
            return;
        }
        
        if (eqwueuqwusdas.Count < 3)
        {
            initialColor = new Color();
            foreach (var fsdfwerwfsdf in eqwueuqwusdas)
            {
                fsdfwerwfsdf.GetComponent<SpriteRenderer>().sprite = _riweriir;
            }
        }
        else
        {
            reqweqweqweq.Dsdasdadcsdfsdf(_eiqieqieias);

            for (var sdfsdfwrw = 0; sdfsdfwrw < riweirwieriwer.Count; sdfsdfwrw++)
            {
                DestroyImmediate(riweirwieriwer[sdfsdfwrw].gameObject);
                riweirwieriwer[sdfsdfwrw] = null;
            }
            gfdgertwrwer = iitweiteirt.Nbdrfwerwer(riweirwieriwer.Count);
            rertegdfgd.Ooewriweriwe();
        }
        
        StartCoroutine(Jruwurwuerw());
        
        HandleUserInput();

        if (!gfdgertwrwer) return;
        reqweqweqweq.Dsdasdadcsdfsdf(_jfsjfsjdf);
        StopAllCoroutines();
        Grtrtwterwer();
        
        RotateObject();
        jjghrtyrth = true;
    }

    IEnumerator Jruwurwuerw()
    {
        jjghrtyrth = true;
        yield return new WaitForSeconds(0.5f);
        Grtrtwterwer();
        jjghrtyrth = false;

    }

    void Grtrtwterwer()
    {
        if (eqwueuqwusdas == null) return;
        foreach (var fgdfter in eqwueuqwusdas)
        {
            // Reset cell to its original state (you can implement your own reset mechanism)
            fgdfter.GetComponent<SpriteRenderer>().sprite = _nbcvnbcnvbcvb;
        }
        eqwueuqwusdas.Clear();
        riweirwieriwer?.Clear();

    }

    public void Hyeqwyeyqwe(bool fghftete)
    {
        jjghrtyrth = fghftete;
    }

    public void Gerwrfsdf()
    {
        jjghrtyrth = true;
        rertegdfgd.Eerwerwesdfsdf();
        jjghrtyrth = false;
    }

    public void Trwerfsdfs()
    {
        reqweqweqweq.Dsdasdadcsdfsdf(_ppweroweor);
    }

}
