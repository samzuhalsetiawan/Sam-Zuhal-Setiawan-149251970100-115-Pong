using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    public GameObject firstHitPaddle;
    private GameObject lastHitPaddle;
    // Start is called before the first frame update
    void Start()
    {
        lastHitPaddle = firstHitPaddle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLastHitPaddle(GameObject paddle)
    {
        lastHitPaddle = paddle;
    }

    public GameObject GetLastHitPaddle()
    {
        return lastHitPaddle;
    }

}
