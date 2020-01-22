using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            // Only works if shift is held down.
        }
        else
        {
            // Only works if shift is not held down.
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * Time.deltaTime * speed;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + Vector3.down * Time.deltaTime * speed;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + Vector3.left * Time.deltaTime * speed;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + Vector3.right * Time.deltaTime * speed;
            }
        }
        // This works if player is holding down shiuft or ISN'T holding down shift
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }

    void Jump()
    {
        // code that makes player jump
    }
}
