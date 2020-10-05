using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlaneController : MonoBehaviour
{


    public GameObject btnToggleOff;
    public GameObject btnToggleOn;


    ARPlaneManager m_arplanemanager;

    private void Awake(){
        m_arplanemanager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Menu",LoadSceneMode.Single);
        }
    }

public void TogglePlaneDetectionVisibility(){
    m_arplanemanager.enabled = !m_arplanemanager.enabled;

    if (m_arplanemanager.enabled){
        SetActiveorDeactive(true);
        GetComponent<ARPlacer>().enabled = true;
        btnToggleOff.SetActive(false);
        btnToggleOn.SetActive(true);
        print("estas buscando planos");
    } else {
        SetActiveorDeactive(false);
        GetComponent<ARPlacer>().enabled = false;
        btnToggleOff.SetActive(true);
        btnToggleOn.SetActive(false);
        print("NO estas buscando planos");
    }

}

    public void IrAEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }



    void SetActiveorDeactive(bool value){
        foreach (var plane in m_arplanemanager.trackables){
            plane.gameObject.SetActive(value);
        }
    }

    public void Volver(){
            SceneManager.LoadScene("mainRIH",LoadSceneMode.Single);
    }

}
