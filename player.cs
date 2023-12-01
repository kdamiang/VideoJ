using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using TMPro;


public class player : MonoBehaviour

{
    
    [Header("References")]
    [SerializeField] TextMeshProUGUI mScoreLabel;
    [SerializeField] PlayerInput mPlayerInput;
    [SerializeField] GameObject mImageGameOver;


    [Header("Values")]
    [SerializeField] float mfForce = 15f;

    bool mbIsDead;
    int miCurrentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnJump()
    {
        if (!mbIsDead)
        {
            //Debug.Log("Jump");
            Rigidbody2D lRigidbody = GetComponent<Rigidbody2D>();
            Vector2 lvForce = new Vector2(0, mfForce);
            lRigidbody.AddForce(lvForce, ForceMode2D.Impulse);
        }

    }
    public void AddScore(int liScore)
    {

        miCurrentScore += liScore;
        mScoreLabel.text = miCurrentScore.ToString();
    }

    public void Kill()
    {
        Debug.Log("muereeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

        mbIsDead = true;

        GetComponent<CircleCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * mfForce * 1, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddTorque(75.0f);


        GameObject.FindObjectOfType<GeneratorPipe>().CancelInvoke("SpawnPipe");
        
        Pipe[] laPipes = GameObject.FindObjectsOfType<Pipe>();

        for (int i = 0; i < laPipes.Length; i++)
            laPipes[i].mfVelocity = 0;

        Background[] laBackground = GameObject.FindObjectsOfType<Background>();
        for (int i = 0; i < laBackground.Length; i++)
            laBackground[i].mfMoveSpeed = 0;

    }
}
