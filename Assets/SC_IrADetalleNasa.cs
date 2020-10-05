using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SC_IrADetalleNasa : MonoBehaviour
{
   public void IrAEscenaDetalleNasa(){
       SceneManager.LoadScene("Sc_TimelineNasa",LoadSceneMode.Single);
   }
}
