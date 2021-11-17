using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    public float countdown2 = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		countdown2 -= Time.deltaTime;

		if (countdown2 <= 0f)
		{
            Debug.Log("Destroy explode");
			Destroy(gameObject, 2);
		}
	}
}
