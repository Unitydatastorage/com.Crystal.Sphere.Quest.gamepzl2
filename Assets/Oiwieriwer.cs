using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Oiwieriwer : MonoBehaviour
{
    public TMP_Text fkskfskfks;
    public TMP_Text ruweurwuruw;
    public TMP_Text djgjgjdfgd;
    
    // Wandering range.
    public float wanderRange = 10.0f;

    // Wandering speed.
    public float wanderSpeed = 2.0f;

    // Health of the GameObject.
    public int health = 100;

    // Damage taken per hit.
    public int damagePerHit = 10;

    private float gdfgdfrwerw;
    private bool hfghfhfghf = false;
    
    private const float HFSHDFHSHDF_WEIRIWERWER = 10f;
    
    // UI Text element to display health.
    public Text healthText;

    // Power-up effect duration.
    public float powerUpDuration = 5.0f;

    // Power-up speed boost.
    public float speedBoost = 2.0f;

    // Initial position of the GameObject.
    private Vector3 initialPosition;

    // Current target position for wandering.
    private Vector3 wanderTarget;

    public event Action Jurwurure;
    
    private float powerUpTimeLeft = 0.0f;

    private void Awake()
    {
        gdfgdfrwerw = HFSHDFHSHDF_WEIRIWERWER;
    }

    void Update()
    {
        if (!hfghfhfghf) return;
        gdfgdfrwerw -= Time.deltaTime; // Decrease the timer by the time passed since the last frame

        // Update the slider value based on the timer progress
        var currentTime = Mathf.Ceil(gdfgdfrwerw); 
        fkskfskfks.text = $"Timer: {currentTime.ToString(CultureInfo.CurrentCulture)}s.";
        ruweurwuruw.text = $"Timer: {currentTime.ToString(CultureInfo.CurrentCulture)}s.";
        djgjgjdfgd.text = $"Timer: {currentTime.ToString(CultureInfo.CurrentCulture)}s.";


        if (!(gdfgdfrwerw <= 0f)) return;
        gdfgdfrwerw = 0f;
        hfghfhfghf = false;
        Jurwurure?.Invoke();
    }

    public void Uurwueruweurw()
    {
        hfghfhfghf = true;
        wanderTarget = new Vector3();
        powerUpTimeLeft = 1f;
        powerUpDuration = 2f;
    }

    public void Iruweurwurw()
    {
        hfghfhfghf = false;
    }

    public void Nfjhfhshfhsdf()
    {
        gdfgdfrwerw = HFSHDFHSHDF_WEIRIWERWER;
        Wander();
        UpdatePowerUpTimer();
    }
    
    
      // Method to handle wandering behavior.
    void Wander()
    {
        // Move towards the current wander target.
        float speed = wanderSpeed * (powerUpTimeLeft > 0 ? speedBoost : 1);
        transform.position = Vector3.MoveTowards(transform.position, wanderTarget, speed * Time.deltaTime);

        // If the GameObject reaches the wander target, set a new target.
        if (Vector3.Distance(transform.position, wanderTarget) < 0.1f)
        {
            HandlePowerUpInput();
        }
    }

    // Method to handle power-up input.
    void HandlePowerUpInput()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Activate power-up effect.
            powerUpTimeLeft = powerUpDuration;
        }
    }

    // Method to update the power-up timer.
    void UpdatePowerUpTimer()
    {
        if (powerUpTimeLeft > 0)
        {
            powerUpTimeLeft -= Time.deltaTime;
        }
    }

    // Method to handle collisions with damaging objects.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DamagingObject"))
        {
            // Reduce health when hit by a damaging object.
            health -= damagePerHit;

            // Update the health UI.
            UpdateHealthUI();

            // Check if health is zero or below.
            if (health <= 0)
            {
                // Destroy the GameObject when health is depleted.
                Destroy(gameObject);
            }
        }
    }

    // Method to update the health UI.
    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }
}
