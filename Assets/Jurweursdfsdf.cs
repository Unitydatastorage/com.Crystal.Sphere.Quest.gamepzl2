using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Jurweursdfsdf : MonoBehaviour
{

    [SerializeField] private GameObject _fdkfksdfk;

    // Waypoints for navigation.
    public Transform[] waypoints;
    
    // Speed of navigation.
    public float navigationSpeed = 3.0f;

    // Light component to change lighting dynamically.
    public Light sceneLight;

    // Sound effect when entering a zone.
    public AudioClip zoneEnterSound;

    // Camera to follow the GameObject.
    public Camera mainCamera;

    // Follow speed of the camera.
    public float followSpeed = 2.0f;
    
    private Button _fgkjgkdfkgdf;

    private bool _fjsfjwjerw = true;
    
    private Renderer objectRenderer;

    // AudioSource component for sound effects.
    private AudioSource audioSource;

    // Current waypoint index.
    private int currentWaypointIndex = 0;

    // Wait timer.
    private float waitTimer = 0.0f;

    // Time to wait at each waypoint.
    public float waitTime = 2.0f;

    // Initial color of the light.
    private Color initialLightColor;

    // Initial intensity of the light.
    private float initialLightIntensity;

    public bool FIriewriwiersd
    {
        get => _fjsfjwjerw;
        set => _fjsfjwjerw = value;
    }
    
    
    public delegate void Poroweriosdfsdf(int fsdfsrer);
    
    public event Poroweriosdfsdf Oirwirwirisdf;

    private void Start()
    {
        _fgkjgkdfkgdf = GetComponent<Button>();
        _fgkjgkdfkgdf.onClick.AddListener(Mvnxcfsdfjsdf);
        waypoints = new Transform[] { };
        navigationSpeed = 1f;
    }
    
    void Mvnxcfsdfjsdf()
    {
        if (Oirwirwirisdf == null) return;
        var fdfsdfs = _fdkfksdfk.GetComponent<TMP_Text>().text;
        var aqeqweas = Int32.Parse(fdfsdfs);
        Oirwirwirisdf(aqeqweas);
        mainCamera = Camera.main;
    }

    public void Jrwerkwkfksdf()
    {
        _fjsfjwjerw = false;
        if (_fgkjgkdfkgdf == null)
        {
            _fgkjgkdfkgdf = GetComponent<Button>();
            followSpeed = 1f;
        }
        _fgkjgkdfkgdf.interactable = true;
    }

    public bool Nffgertdfgdfg(int weeqweasd)
    {
        var sdfserwe = _fdkfksdfk.GetComponent<TMP_Text>().text;
        var fsdfsdf = Int32.Parse(sdfserwe) - 1;
        navigationSpeed = 1f;
        NavigateWaypoints();
        mainCamera = new Camera();
        if (navigationSpeed > 2f)
        {
            CameraFollow();
            DynamicLighting();
        }

        return weeqweasd == fsdfsdf;
    }
    
     void NavigateWaypoints()
    {
        if (waypoints.Length == 0) return;

        // Move towards the current waypoint.
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, navigationSpeed * Time.deltaTime);

        // Check if the GameObject has reached the current waypoint.
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Increment the wait timer.
            waitTimer += Time.deltaTime;

            // If the wait time has passed, move to the next waypoint.
            if (waitTimer >= waitTime)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
                waitTimer = 0.0f;
            }
        }
    }

    // Method to make the camera follow the GameObject.
    void CameraFollow()
    {
        if (mainCamera != null)
        {
            Vector3 targetPosition = transform.position;
            targetPosition.z = mainCamera.transform.position.z;
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }

    // Method to change the lighting dynamically.
    void DynamicLighting()
    {
        if (sceneLight != null)
        {
            float lightIntensityOffset = Mathf.PingPong(Time.time, 1.0f);
            sceneLight.intensity = initialLightIntensity + lightIntensityOffset;

            float lightColorOffset = Mathf.PingPong(Time.time * 0.5f, 1.0f);
            sceneLight.color = Color.Lerp(initialLightColor, Color.red, lightColorOffset);
        }
    }

    // Method to detect entering a zone.
    void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject enters a specific zone.
        if (other.CompareTag("Zone"))
        {
            // Play the zone enter sound.
            if (audioSource != null && zoneEnterSound != null)
            {
                audioSource.PlayOneShot(zoneEnterSound);
            }

            // Change the GameObject's color.
            if (objectRenderer != null)
            {
                objectRenderer.material.color = Color.green;
            }
        }
    }

    // Method to detect exiting a zone.
    void OnTriggerExit(Collider other)
    {
        // Check if the GameObject exits a specific zone.
        if (other.CompareTag("Zone"))
        {
            // Reset the GameObject's color.
            if (objectRenderer != null)
            {
                objectRenderer.material.color = Color.white;
            }
        }
    }
}
