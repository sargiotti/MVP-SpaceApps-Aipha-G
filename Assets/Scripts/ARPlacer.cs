using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class ARPlacer : MonoBehaviour
{
    ARRaycastManager m_ARRaycastManager;


    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    public GameObject locationBasedARPrefab;


    private void Awake(){
        m_ARRaycastManager = GetComponent<ARRaycastManager>();
        Application.targetFrameRate = 120;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if (m_ARRaycastManager.Raycast(touch.position, raycastHits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon)){
                //Getting use pose
                Pose pose = raycastHits[0].pose;

                locationBasedARPrefab.transform.position = pose.position;
            }
        }


    }
}
