using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    public float countdown = 0.2f;

	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		countdown -= Time.deltaTime;
		if (countdown <= 0f)
		{
           // Debug.Log("Destroy explode");
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
    {
	   if(collider.tag == "Player" || collider.tag == "Player2") {
			Debug.Log("Destroy player: " + collider.tag);
			Destroy(collider.gameObject);
	   }
    }
}
