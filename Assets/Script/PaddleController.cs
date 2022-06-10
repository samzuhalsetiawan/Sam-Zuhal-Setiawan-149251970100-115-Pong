using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
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
            Debug.Log("Kecepatan Paddle: " + rig.velocity);
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
        // transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }
}
