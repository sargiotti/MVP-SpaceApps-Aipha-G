using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_VolverANASA : MonoBehaviour
{
    // Start is called before the first frame update
    public void VolverANASA(){
        SceneManager.LoadScene("SC_MenuNasa",LoadSceneMode.Single);
    }
}
