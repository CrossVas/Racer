using UnityEngine;

public class SubRacer : Racer {
    
    // Initiating components one more time, otherwise it won't work 
    
    public void Start() {
        base.racerColor = Color.blue;
        base.racer = GetComponent<Rigidbody2D>();
        base.aRenderer = GetComponent<Renderer>();
        Debug.Log($"Blue Racer Speed: {speed}");
        base.overlayInfo.text = $"Blue Racer Speed: {speed}";
    }

    public void startRace() {
        base.startRace();
    }
}
