using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] public float mfMoveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position - Vector2.right * Time.deltaTime * mfMoveSpeed;

        if (transform.position.x < -17f)
        {
            transform.position = new Vector3(transform.position.x + 12 * 3, transform.position.y, transform.position.z);
        }

    }
}
