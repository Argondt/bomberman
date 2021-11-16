using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawnerScript : MonoBehaviour
{
	public Tilemap tilemap;

	public GameObject bomb;




	// Update is called once per frame
	void Update()
	{
		


		if (Input.GetKey("space"))

		{
			Debug.Log("bomb");
			//Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2  worldPos = Camera.main.ScreenToWorldPoint(GameObject.FindGameObjectWithTag("Player").transform.position);
			Vector3Int cell = tilemap.WorldToCell(worldPos);
			Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

			Instantiate(bomb, cellCenterPos, Quaternion.identity);
		}
	}
}
