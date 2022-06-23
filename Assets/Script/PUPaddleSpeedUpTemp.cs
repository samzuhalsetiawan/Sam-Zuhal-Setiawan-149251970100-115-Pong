using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUpTemp : MonoBehaviour
{
    public Collider2D ballCollider;
    public PaddleManager paddleManager;
    public PowerUpManager powerUpManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ballCollider)
        {
            GameObject lastHitPaddle = paddleManager.GetLastHitPaddle();
            lastHitPaddle.GetComponent<PaddleController>().ActivatePUSpeedUpPaddle();
            powerUpManager.RemovePowerUp(gameObject);
        }
    }
}
