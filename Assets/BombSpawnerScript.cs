using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawnerScript : MonoBehaviour
{
	public Tilemap tilemap;
	public GameObject bomb;
	
	private bool bombSetted;

	void Start() {
		bombSetted = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("space") && !bombSetted)
		{
			Debug.Log("bomb");
			// Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3  worldPos = GameObject.FindGameObjectWithTag("Player").transform.position;
			Debug.Log(worldPos);
			Vector3Int cell = tilemap.WorldToCell(worldPos);
			Debug.Log(cell);
			Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);
			Debug.Log(cellCenterPos);

			Instantiate(bomb, cellCenterPos, Quaternion.identity);
			bombSetted = true;

		}

		if (Input.GetKeyUp("space"))
        {
			bombSetted = false;
            print("Space key was released");
        }

		if (Input.GetKey(KeyCode.Return) && !bombSetted)
		{
			Debug.Log("bomb");
			// Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3  worldPos = GameObject.FindGameObjectWithTag("Player2").transform.position;
			Debug.Log(worldPos);
			Vector3Int cell = tilemap.WorldToCell(worldPos);
			Debug.Log(cell);
			Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);
			Debug.Log(cellCenterPos);

			Instantiate(bomb, cellCenterPos, Quaternion.identity);
			bombSetted = true;

		}

		if (Input.GetKeyUp(KeyCode.Return))
        {
			bombSetted = false;
            print("Space key was released");
        }
	}
}
