using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Racer : MonoBehaviour {
    
    // Variables declaration - Object Components
    
    protected Rigidbody2D racer;
    protected Renderer aRenderer;
    protected Color racerColor; // using a variable to store color for each racer

    // Variables declaration - Object Speed (integer)
    
    protected int speed;
    
    // Audio

    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    
    // UI Components 

    public Canvas startButton;
    public Canvas overlayCanvas;
    public Text overlayInfo;

    // General Use Components are initiated in Awake function
    
    private void Awake() {
        speed = Random.Range(20, 70);                   
        audioSource = GetComponent<AudioSource>();
        startButton.enabled = true;                     
        overlayCanvas.enabled = false;
    }
    
    // Per Object Components and info are initiated in Start function for convenience
    
    void Start() {
        racerColor = Color.red; 
        racer = GetComponent<Rigidbody2D>();
        aRenderer = GetComponent<Renderer>();    
        Debug.Log($"Red Racer Speed: {speed}");    
        overlayInfo.text = $"Red Racer Speed: {speed}";
    }

    public void startRace() {
        aRenderer.material.color = racerColor;
        startButton.enabled = false;
        overlayCanvas.enabled = true;
        audioSource.clip = backgroundMusic;
        audioSource.Play();
        racer.AddForce(transform.right * speed);
        racer.AddForce(transform.right * speed);
        racer.AddForce(transform.right * speed);
    }
}
