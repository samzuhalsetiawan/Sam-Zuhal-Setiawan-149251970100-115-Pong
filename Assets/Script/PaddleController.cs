using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public PaddleManager manager;
    public PowerUpManager powerUpManager;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            //Debug.Log("Kecepatan Paddle: " + rig.velocity);
            return Vector3.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            Debug.Log("Kecepatan Paddle: " + rig.velocity);
            return Vector3.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.SetLastHitPaddle(gameObject);
    }

    public void ActivatePUExtendPaddle()
    {
        Vector3 newScale = new(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
        transform.localScale = newScale;
        Invoke(nameof(ExtendPULifeTime), 5f);
    }

    private void ExtendPULifeTime()
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
    }

    public void ActivatePUSpeedUpPaddle()
    {
        speed *= 2;
        Invoke(nameof(SpeedUpPULifeTime), 5f);
    }

    private void SpeedUpPULifeTime()
    {
        speed /= 2;
    }
}
