using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuConecta2 : MonoBehaviour
{
    public void VeAMenu() {
        SceneManager.LoadScene("Menu Juegos");
    }

    public void VeAJuego() {
        SceneManager.LoadScene("Conecta2V");
    }

    public void VeATutorial()
    {
        SceneManager.LoadScene("Conecta2T");
    }
}
