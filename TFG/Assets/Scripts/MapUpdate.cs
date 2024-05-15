using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using Mapbox.Examples;

public class MapUpdate : MonoBehaviour
{
    public AbstractMap map;

    public float followingSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            Vector2d playerLoc = new Vector2d(Input.location.lastData.latitude, Input.location.lastData.longitude);
            map.UpdateMap(playerLoc, map.Zoom);
        }
    }

    private void OnDestroy()
    {
        Input.location.Stop();
    }
}
