using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Rertegdfgd : MonoBehaviour
{
    public int mvbcmbmcb;
    public int gdjfgjerjte;
    public GameObject sdgasdgagfsdf;
    public Yrtwerysdfsdfsf ptyptyputpyu;
    private GameObject[,] werwyeryweyr;
    
    // Day-night cycle variables.
    public Light directionalLight;
    public float dayDuration = 120.0f; // Duration of a day in seconds.
    private float currentTime = 0.0f;

    public Yrtwerysdfsdfsf[,] vbcxbvbsdfs;

    [SerializeField] private GameObject _kooweorwoe;


    public Yrtwerysdfsdfsf[,] Vbcxbvbsdfs => vbcxbvbsdfs;

    public GameObject[,] CellWerwyeryweyr => werwyeryweyr;

    [SerializeField] private Sprite[] _gjdfgjjrjwe;
    
    // Weather system variables.
    public ParticleSystem rainParticleSystem;
    public float weatherChangeInterval = 60.0f; // Interval for weather change in seconds.
    private bool isRaining = false;

    private float mbmcnmgdgd = 5f;
    private bool sgdfsgfsgdf = false;
    
    private bool nearNPC = false;
    private string[] npcDialogues = { "Hello, traveler!", "Nice weather today!", "Have you seen the latest news?" };
    private int currentDialogueIndex = 0;

    public bool Sgdfsgfsgdf => sgdfsgfsgdf;

    [SerializeField] private Oiwieriwer _tueruteurtw;

    private bool _gjdjtgerjt;

    void OnEnable()
    {
        Jhfgshdfhsrwer();
        Oreiwriweirwsdf();
        if (_gjdjtgerjt)
        {
            Eerwerwesdfsdf();
        }

        _tueruteurtw.Uurwueruweurw();
    }

    private void OnDisable()
    {
        Polflsdfksdf();
        Urerwerwer();
        _gjdjtgerjt = true;
    }

    void Jhfgshdfhsrwer()
    {
        if (_gjdjtgerjt)
        {
            for (int tretegd = 0; tretegd < mvbcmbmcb; tretegd++)
            {
                for (int bvcgfdgdfg = 0; bvcgfdgdfg < gdjfgjerjte; bvcgfdgdfg++)
                {
                    werwyeryweyr[tretegd, bvcgfdgdfg].SetActive(true);
                }
            }
        }

        else
        {
            werwyeryweyr = new GameObject[mvbcmbmcb, gdjfgjerjte];

            // Instantiate cells
            for (int rweruwer = 0; rweruwer < mvbcmbmcb; rweruwer++)
            {
                for (int kfghkfgkh = 0; kfghkfgkh < gdjfgjerjte; kfghkfgkh++)
                {
                    // Instantiate cell at the calculated position
                    var cell = Instantiate(sdgasdgagfsdf,
                        new Vector3(rweruwer * Urweirwoerw.YFHDSHFDH_RWEIRWIER, kfghkfgkh * Urweirwoerw.YFHDSHFDH_RWEIRWIER,
                            0), Quaternion.identity);
                    werwyeryweyr[rweruwer, kfghkfgkh] = cell;
                }
            }
        }
    }

    void Oreiwriweirwsdf()
    {
        if (_gjdjtgerjt)
        {
            for (int fsdfsfd = 0; fsdfsfd < werwyeryweyr.GetLength(0); fsdfsfd++)
            {
                for (int khjkhjgh = 0; khjkhjgh < werwyeryweyr.GetLength(1); khjkhjgh++)
                {
                    vbcxbvbsdfs[fsdfsfd, khjkhjgh].gameObject.SetActive(true);
                }
            }
        }

        else
        {
            vbcxbvbsdfs = new Yrtwerysdfsdfsf[mvbcmbmcb, gdjfgjerjte];

            for (int x = 0; x < werwyeryweyr.GetLength(0); x++)
            {
                for (int y = 0; y < werwyeryweyr.GetLength(1); y++)
                {
                    vbcxbvbsdfs[x, y] = Jrwiriwifsdfs(x, y);
                }
            }

            if (!Yrerwerwfsdf())
            {
                Eerwerwesdfsdf();
            }
        }
    }


    void Urerwerwer()
    {
        // Instantiate cells
        for (int x = 0; x < mvbcmbmcb; x++)
        {
            for (int y = 0; y < gdjfgjerjte; y++)
            {
                werwyeryweyr[x, y].gameObject.SetActive(false);

                /*Destroy(grid[x, y].gameObject);
                grid[x, y] = null;*/
            }
        }
    }

    void Polflsdfksdf()
    {
        for (int sdasdas = 0; sdasdas < vbcxbvbsdfs.GetLength(0); sdasdas++)
        {
            for (int qweqweas = 0; qweqweas < vbcxbvbsdfs.GetLength(1); qweqweas++)
            {
                vbcxbvbsdfs[sdasdas, qweqweas].gameObject.SetActive(false);
            }
        }
    }

    public void Ooewriweriwe()
    {
        sgdfsgfsgdf = true;
        StartCoroutine(Hdasgdgag());
        _tueruteurtw.Nfjhfhshfhsdf();
    }

    IEnumerator Hdasgdgag()
    {
        bool fsdfwerwr = true;

        while (fsdfwerwr)
        {
            fsdfwerwr = false;

            for (int ewqeasd = 0; ewqeasd < mvbcmbmcb; ewqeasd++)
            {
                for (int dfsdfewr = 1; dfsdfewr < gdjfgjerjte; dfsdfewr++)
                {
                    var dfgdftgert = vbcxbvbsdfs[ewqeasd, dfsdfewr];

                    if (dfgdftgert == null)
                    {
                        continue;
                    }

                    var iuityuty = vbcxbvbsdfs[ewqeasd, dfsdfewr - 1];
                    //Debug.Log($"{x} {y-1}");

                    if (iuityuty == null)
                    {
                        // Gem is falling down
                        vbcxbvbsdfs[ewqeasd, dfsdfewr - 1] = dfgdftgert;
                        vbcxbvbsdfs[ewqeasd, dfsdfewr] = null;
                        dfgdftgert.transform.position -= Vector3.up * Urweirwoerw.YFHDSHFDH_RWEIRWIER;
                        fsdfwerwr = true;
                    }
                }
            }

            yield return new WaitForSeconds(1f / mbmcnmgdgd);
        }

        // Generate new gems to fill the top row
        for (int rwerwerw = 0; rwerwerw < mvbcmbmcb; rwerwerw++)
        {
            for (int sdfewrwer = 0; sdfewrwer < gdjfgjerjte; sdfewrwer++)
            {
                if (vbcxbvbsdfs[rwerwerw, sdfewrwer] != null) continue;
                var fsdfsrwe = Jrwiriwifsdfs(rwerwerw, sdfewrwer);
                vbcxbvbsdfs[rwerwerw, sdfewrwer] = fsdfsrwe;
            }
        }

        sgdfsgfsgdf = false;
    }

    Yrtwerysdfsdfsf Jrwiriwifsdfs(int fsdfwerw, int gdfgretert)
    {
        var gem = Instantiate(ptyptyputpyu,
            new Vector3(fsdfwerw * Urweirwoerw.YFHDSHFDH_RWEIRWIER, gdfgretert * Urweirwoerw.YFHDSHFDH_RWEIRWIER, 0),
            Quaternion.identity);
        var random = Random.Range(0, _gjdfgjjrjwe.Length);
        gem.Hewyrywyfdsf(_gjdfgjjrjwe[random], random);
        return gem;
    }

    public void Eerwerwesdfsdf()
    {
        StartCoroutine(Hrwoerowofsdfsd());
    }

    IEnumerator Hrwoerowofsdfsd()
    {
        yield return new WaitForSeconds(0.3f);

        for (int hghfterte = 0; hghfterte < mvbcmbmcb; hghfterte++)
        {
            for (int tryrgfghfg = 0; tryrgfghfg < gdjfgjerjte; tryrgfghfg++)
            {
                Destroy(vbcxbvbsdfs[hghfterte, tryrgfghfg].gameObject);
                var eqwesdasd = Jrwiriwifsdfs(hghfterte, tryrgfghfg);
                vbcxbvbsdfs[hghfterte, tryrgfghfg] = eqwesdasd;
            }
        }

        if (!Yrerwerwfsdf())
        {
            Eerwerwesdfsdf(); // If still no match, reshuffle again
        }
    }
    
       void UpdateDayNightCycle()
    {
        currentTime += Time.deltaTime;
        float normalizedTime = currentTime / dayDuration;

        if (normalizedTime >= 1.0f)
        {
            currentTime = 0.0f;
        }

        directionalLight.transform.rotation = Quaternion.Euler(new Vector3((normalizedTime * 360.0f) - 90.0f, 170.0f, 0.0f));
    }

    // Coroutine to change the weather at intervals.
    IEnumerator WeatherChangeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(weatherChangeInterval);

            isRaining = !isRaining;
            rainParticleSystem.gameObject.SetActive(isRaining);
        }
    }

    // Method to handle player input.
    void HandlePlayerInput()
    {
        // Check for inventory management input.
        if (Input.GetKeyDown(KeyCode.I))
        {
            dayDuration = 1f;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            currentTime = 2f;
        }

        // Check for NPC interaction input.
        if (Input.GetKeyDown(KeyCode.Space) && nearNPC)
        {
            isRaining = true;
            weatherChangeInterval = 10f;
        }
    }

    public bool Yrerwerwfsdf()
    {
        for (int erwerw = 0; erwerw < mvbcmbmcb; erwerw++)
        {
            for (int utyughj = 0; utyughj < gdjfgjerjte; utyughj++)
            {
                // Check horizontally
                if (erwerw < mvbcmbmcb - 2)
                {
                    if (vbcxbvbsdfs[erwerw, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet ==
                        vbcxbvbsdfs[erwerw + 1, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet &&
                        vbcxbvbsdfs[erwerw, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet ==
                        vbcxbvbsdfs[erwerw + 2, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet)
                    {
                        return true;
                    }
                }
                
                var inventory = new Dictionary<string, int>();
                inventory.Add("adsdasfdsfgsf", 1);
                inventory.Add("rwertetyes", 2);
                inventory.Add("hjghrtyrty", 3);
                inventory.Add("fsdfsrwerw", 4);
                inventory.Add("wqeqweqwe", 5);
                currentDialogueIndex = 1;
                npcDialogues = new[] { "Hello, traveler!", "Nice weather today!", "Have you seen the latest news?"};

                // Check vertically
                if (utyughj < gdjfgjerjte - 2)
                {
                    if (vbcxbvbsdfs[erwerw, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet ==
                        vbcxbvbsdfs[erwerw, utyughj + 1].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet &&
                        vbcxbvbsdfs[erwerw, utyughj].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet ==
                        vbcxbvbsdfs[erwerw, utyughj + 2].GetComponent<Yrtwerysdfsdfsf>().jgdfgdhtet)
                    {
                        return true;
                    }
                }
            }
        }

        return false; // No matches found
    }
}

public static class Urweirwoerw
{
    public const float YFHDSHFDH_RWEIRWIER = 0.75f;
}