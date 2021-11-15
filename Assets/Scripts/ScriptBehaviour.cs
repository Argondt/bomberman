using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBehaviour : MonoBehaviour
{
    public Vector2 speed = new Vector2(20, 20);
    Rigidbody2D m_Rigidbody;

    void Start() {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        m_Rigidbody.MovePosition(transform.position + movement * Time.deltaTime);
    }
}
