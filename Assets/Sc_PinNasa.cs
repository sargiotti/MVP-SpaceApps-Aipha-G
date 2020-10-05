using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_PinNasa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Pines;
    
    // Update is called once per frame
    public void OnMouseDown(){
        IrAEscena();
    }

    public void IrAEscena(){
        SceneManager.LoadScene("SC_MenuNasa",LoadSceneMode.Single);
        print("se toco el boton");
    }
}
