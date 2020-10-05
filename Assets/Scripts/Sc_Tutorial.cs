using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Tutorial : MonoBehaviour
{
    public GameObject promptTutorial;

    public void CerrarPrompt(){
        promptTutorial.SetActive(false);
    }
    public void AbrirPrompt(){
        promptTutorial.SetActive(true);
    }
}
