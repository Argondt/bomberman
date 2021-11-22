using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDestroyer : MonoBehaviour
{
    public Tilemap tilemap;

    public Tile wallTile;
    public Tile destructableTile;

    public GameObject explosionPrefab;

    public void Explode(Vector2 worldPos) {
        Vector3Int originCell = tilemap.WorldToCell(worldPos);
        ExplodeCell(originCell);
        if(ExplodeCell(originCell + new Vector3Int(1,0,0)))
        {
            ExplodeCell(originCell + new Vector3Int(2,0,0));
        }

        if(ExplodeCell(originCell + new Vector3Int(-1,0,0))) 
        {
            ExplodeCell(originCell + new Vector3Int(-2,0,0));
        }

        if(ExplodeCell(originCell + new Vector3Int(0,1,0)))
        {
            ExplodeCell(originCell + new Vector3Int(0,2,0));
        }

        if(ExplodeCell(originCell + new Vector3Int(0,-1,0)))
        {
            ExplodeCell(originCell + new Vector3Int(0,-2,0));
        }
    }

    private bool ExplodeCell(Vector3Int cell) {
        Tile tile = tilemap.GetTile<Tile>(cell);
        bool destroyNext = true;

        if(tile == wallTile) {
            return false;
        }
        if(tile == destructableTile) {
            tilemap.SetTile(cell, null);
            destroyNext = false;
        }
        // Debug.Log("Air Explode "+ cell);
        Vector3 pos = tilemap.GetCellCenterWorld(cell);
        Instantiate(explosionPrefab, pos, Quaternion.identity);

        return destroyNext;
    }
}
