using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    [SerializeField] public float mfVelocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.right * Time.deltaTime * mfVelocity);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        player player = collision.transform.GetComponent<player>();
        if (player)
            player.Kill();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("un punto");
        player player = collision.transform.GetComponent<player>();
        if (player)
            player.AddScore(1);

    }
}
