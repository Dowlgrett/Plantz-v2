using UnityEngine;
using UnityEngine.Tilemaps;

public class CenterCameraOnTilemap : MonoBehaviour
{
    public Tilemap tilemap;

    public void CenterCamera()
    {
        if (tilemap != null)
        {
            // Step 1: Get the bounds of the Tilemap
            BoundsInt tilemapBounds = tilemap.cellBounds;

            // Step 2: Calculate the center of the Tilemap bounds
            Vector3 tilemapCenter = new Vector3(tilemapBounds.center.x, tilemapBounds.center.y, 0f);

            // Step 3: Position the camera at the calculated center
            Camera.main.transform.position = new Vector3(tilemapCenter.x, tilemapCenter.y, Camera.main.transform.position.z);
        }
        else
        {
            Debug.LogError("Tilemap reference is not set!");
        }

    }
}
