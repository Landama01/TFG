using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mapbox.Examples;
using Mapbox.Utils;

public class EventPointer : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    [SerializeField] float amplitude = 2f;
    [SerializeField] float frequency = 0.5f;

    LocationStatus playerLoc;
    public Vector2d eventPos;

    UI_Manager menuUIManager;
    // Start is called before the first frame update
    void Start()
    {
        menuUIManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        FloatAndRotatePointer();
    }

    private void FloatAndRotatePointer()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.fixedTime*Mathf.PI*frequency)*amplitude)+15,transform.position.z);
    }

    private void OnMouseDown()
    {
        playerLoc = GameObject.Find("Canvas").GetComponent<LocationStatus>();
        var currentPlayerLoc = new GeoCoordinatePortable.GeoCoordinate(playerLoc.GetLocationLat(), playerLoc.GetLocationLon());
        var eventLoc = new GeoCoordinatePortable.GeoCoordinate(eventPos[0], eventPos[1]);
        var distance = currentPlayerLoc.GetDistanceTo(eventLoc);
        Debug.Log("Distance is: " + distance);        
        
        if(distance < 75)
        {
            menuUIManager.DisplayEventMenuInRange();
        }
        else
        {
            menuUIManager.DisplayEventMenuNotInRange();
        }
    }
}
