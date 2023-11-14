using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialConectados : MonoBehaviour
{
    //Gameobjects de tipo UI
    public GameObject paso;
    public GameObject explicacion;
    public GameObject explicacion_aux;

    public GameObject sig_boton;
    public GameObject fin_boton;

    //Sprites de explicacion.
    public Sprite mecanica_sp;
    public Sprite distractor_sp;
    public Sprite victoria_sp;
    public Sprite derrota_sp;

    private bool _sig;

    // Start is called before the first frame update
    void Start()
    {
        _sig = false;
        fin_boton.SetActive(false);
        explicacion_aux.SetActive(false);

        StartCoroutine(TutorialFlujo());
    }

    public void SiguientePaso()
    {
        _sig = true;
    }

    public void BotonFinal()
    {
        sig_boton.SetActive(false);
        fin_boton.SetActive(true);
    }

    public void VolverPrincipal()
    {
        SceneManager.LoadScene("MenuConecta2");
    }

    IEnumerator TutorialFlujo()
    {
        paso.GetComponent<Image>().sprite = mecanica_sp;
        explicacion.GetComponent<Text>().text = "Memoriza el orden en el que la figura se dibuja y coloca las líneas en el orden correcto.";
        while (!_sig)
        {
            yield return null;
        }
        _sig = false;

        paso.GetComponent<Image>().sprite = distractor_sp;
        explicacion.GetComponent<Text>().text = "Algunos niveles tienen líneas falsas.";
        explicacion.GetComponent<Text>().color = new Color(255, 145, 0, 255);
        explicacion_aux.SetActive(true);
        explicacion_aux.GetComponent<Text>().text = "Puedes corregir tu respuesta borrando la acción anterior.";
        explicacion_aux.GetComponent<Text>().color = Color.blue;
        while (!_sig)
        {
            yield return null;
        }
        _sig = false;

        
        paso.GetComponent<Image>().sprite = victoria_sp;
        explicacion.GetComponent<Text>().text = "Sube de nivel para ver más figuras al completar bien 4 figuras.";
        explicacion.GetComponent<Text>().color = Color.black;
        explicacion_aux.SetActive(false);
        while (!_sig)
        {
            yield return null;
        }
        BotonFinal();

        paso.GetComponent<Image>().sprite = derrota_sp;
        explicacion.GetComponent<Text>().text = "Si te equivocas en 4 figuras, bajarás de nivel.";
    }
}
