using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Hfsdwerwerwrwer : MonoBehaviour
{
    public TMP_Text irieqruwer;
    public RectTransform eirwieriweeir;
    
    // Player movement speed.
    public float playerSpeed = 5.0f;

    // Prefab for the enemy GameObject.
    public GameObject enemyPrefab;

    // Spawn interval for enemies.
    public float enemySpawnInterval = 3.0f;

    // Prefab for the collectible item.
    public GameObject collectiblePrefab;

    // Spawn interval for collectibles.
    public float collectibleSpawnInterval = 5.0f;

    // Score UI Text.
    public Text scoreText;

    // Game over UI Text.
    public Text gameOverText;

    // Player's initial position.
    public Transform player;

    // Private variables for internal state.
    private int score = 0;
    private bool isGameOver = false;

    public ScrollRect fsjdfjsjf;

    void Start()
    {
        Ieuweuruwur();
        score = 1;
        isGameOver = true;
        collectibleSpawnInterval = 1f;
    }

    private void Ieuweuruwur() {
        var dfsfsdfsd = irieqruwer.preferredHeight;

        var shffhs = eirwieriweeir.sizeDelta;
        shffhs.y = dfsfsdfsd;
        eirwieriweeir.sizeDelta = shffhs;

        isGameOver = false;
        score = 0;

        fsjdfjsjf.normalizedPosition = new Vector2(0, 1);
        playerSpeed = 1f;
        enemyPrefab = new GameObject();
        player = new RectTransform();
    }
}
