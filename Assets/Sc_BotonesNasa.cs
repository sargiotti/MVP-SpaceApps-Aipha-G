using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sc_BotonesNasa : MonoBehaviour
{
    // Start is called before the first frame update
    public void IrAEscena(){
        SceneManager.LoadScene("SC_SeleccionAgencia",LoadSceneMode.Single);
    }

    // Update is called once per frame
}
