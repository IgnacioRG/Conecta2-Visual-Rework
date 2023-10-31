using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using System.Linq;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
public class JuegoScript : MonoBehaviour
{
    
    public GameObject[] figurasNivel1, moldesNivel1, figurasNivel2, moldesNivel2, figurasNivel3, moldesNivel3, figurasNivel4, moldesNivel4, figurasNivel5, moldesNivel5, figurasNivel6, moldesNivel6, figurasNivel7, moldesNivel7, figurasNivel8, moldesNivel8, figurasNivel9, moldesNivel9, figurasNivel10, moldesNivel10, figurasNivel11, moldesNivel11,figurasNivel12, moldesNivel12, posicionesParaLineas;

    public GameObject[] distractoresNivel4, distractoresNivel5_6, distractoresNivel7_8, distractoresNivel9_10, distractoresNivel11_12;

    public GameObject avisosPanel, correctoPanel, incorrectoPanel, siguienteNivelPanel, regresaNivelPanel, mismoNivelPanel, bloqueoClicksPanel;

    public Text avisosText, contadorAciertosText, contadorErroresText, nivelText;

    public Button botonBorrar, botonListo;

    public int elegirNivel;

    System.Random _numeroAleatorio = new System.Random();
    
    System.Random _numeroAleatorio2 = new System.Random();

    private GameObject _figuraElegida, _moldeElegido;

    private int _nivel, _aciertos, _errores, _numeroLineasUtilizadas, _numeroDistractoresUtilizados;

    private int _ultimaFiguraUtilizada = -1;
    
    private List<GameObject> _posicionesElegidas = new List<GameObject>();
    
    private List<GameObject> _distractoresElegidos = new List<GameObject>();

    private List<int> _selectorFiguras = new List<int>();
    
    private List<int> _selectorLineas = new List<int>();
    
    private List<int> _selectorDistractores = new List<int>();

    private List<int> _selectorPosiciones = new List<int>();

    private List<int> _respuestaEsperada = new List<int>();

    private List<int> _selectorColores = new List<int>();
    
    public List<int> _respuestaJugador = new List<int>();

    public AudioSource bocina;
    public AudioClip victoria_audioclip;
    public AudioClip derrota_audioclip;
    public AudioClip subeNivel_audioclip;
    public AudioClip bajaNivel_audioclip;
    
    void Awake(){

        //Se puede usar la variable publica elegirNivel para iniciar en
        //otro nivel diferente al 1 si asi se desea
        if (elegirNivel > 0 && elegirNivel <= 12){

            _nivel = elegirNivel;
        }
        else{
            _nivel = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        avisosPanel.SetActive(true);
        correctoPanel.SetActive(false);
        incorrectoPanel.SetActive(false);
        siguienteNivelPanel.SetActive(false);
        regresaNivelPanel.SetActive(false);
        bloqueoClicksPanel.SetActive(false);
        mismoNivelPanel.SetActive(false);
        
        avisosText.text = "Memoriza el orden en que aparecen las líneas";
        contadorAciertosText.text = "0/5";
        contadorErroresText.text = "0/5";
        nivelText.text = _nivel.ToString();

        ActivadorDeBotones();

        botonBorrar.enabled = false;
        botonListo.enabled = false;

        _aciertos = 0;
        _errores = 0; 

        SeleccionarNivel();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    //Metodo para asignar acciones a botones de borrar y listo
    void ActivadorDeBotones(){

            botonBorrar.onClick.AddListener(() => Borrar());
            botonListo.onClick.AddListener(() => RevisarRespuesta());
    }


    //Metodo para cargar ajustes de nuevo nivel
    void SeleccionarNivel(){

        _selectorLineas.Clear();
        _respuestaEsperada.Clear();
        _respuestaJugador.Clear();
        _posicionesElegidas.Clear();
        contadorAciertosText.text = _aciertos.ToString() + "/5";
        contadorErroresText.text = _errores.ToString() + "/5";
        nivelText.text = _nivel.ToString();
        avisosText.text = "Memoriza el orden en que aparecen las líneas";
        avisosPanel.SetActive(true);

        switch(_nivel){
            case 1:
                _numeroLineasUtilizadas = 3;
                _numeroDistractoresUtilizados = 0;
                StartCoroutine(MostrarNuevaFigura(figurasNivel1,moldesNivel1, _numeroLineasUtilizadas, distractoresNivel4, _numeroDistractoresUtilizados ));

            break;
            case 2:
                _numeroLineasUtilizadas = 4;
                _numeroDistractoresUtilizados = 0;
                StartCoroutine(MostrarNuevaFigura(figurasNivel2,moldesNivel2, _numeroLineasUtilizadas, distractoresNivel4, _numeroDistractoresUtilizados));

            break;
            case 3:
                _numeroLineasUtilizadas = 3;
                _numeroDistractoresUtilizados = 0;
                StartCoroutine(MostrarNuevaFigura(figurasNivel3,moldesNivel3, _numeroLineasUtilizadas, distractoresNivel4, _numeroDistractoresUtilizados));

            break;
            case 4:
                _numeroLineasUtilizadas = 4;
                _numeroDistractoresUtilizados = 1;
                StartCoroutine(MostrarNuevaFigura(figurasNivel4,moldesNivel4, _numeroLineasUtilizadas, distractoresNivel4, _numeroDistractoresUtilizados));

            break;
            case 5:
                _numeroLineasUtilizadas = 5;
                _numeroDistractoresUtilizados = 1;
                StartCoroutine(MostrarNuevaFigura(figurasNivel5,moldesNivel5, _numeroLineasUtilizadas, distractoresNivel5_6, _numeroDistractoresUtilizados));

            break;
            case 6:
                _numeroLineasUtilizadas = 6;
                _numeroDistractoresUtilizados = 2;
                StartCoroutine(MostrarNuevaFigura(figurasNivel6,moldesNivel6, _numeroLineasUtilizadas, distractoresNivel5_6, _numeroDistractoresUtilizados));

            break;
            case 7:
                _numeroLineasUtilizadas = 5;
                _numeroDistractoresUtilizados = 2;
                StartCoroutine(MostrarNuevaFigura(figurasNivel7,moldesNivel7, _numeroLineasUtilizadas, distractoresNivel7_8, _numeroDistractoresUtilizados));

            break;
            case 8:
                _numeroLineasUtilizadas = 6;
                _numeroDistractoresUtilizados = 2;
                StartCoroutine(MostrarNuevaFigura(figurasNivel8,moldesNivel8, _numeroLineasUtilizadas, distractoresNivel7_8, _numeroDistractoresUtilizados));

            break;
            case 9:
                _numeroLineasUtilizadas = 7;
                _numeroDistractoresUtilizados = 3;
                StartCoroutine(MostrarNuevaFigura(figurasNivel9,moldesNivel9, _numeroLineasUtilizadas, distractoresNivel9_10, _numeroDistractoresUtilizados));

            break;
            case 10:
                _numeroLineasUtilizadas = 8;
                _numeroDistractoresUtilizados = 3;
                StartCoroutine(MostrarNuevaFigura(figurasNivel10,moldesNivel10, _numeroLineasUtilizadas, distractoresNivel9_10, _numeroDistractoresUtilizados));

            break;
            case 11:
                _numeroLineasUtilizadas = 7;
                _numeroDistractoresUtilizados = 3;
                StartCoroutine(MostrarNuevaFigura(figurasNivel11,moldesNivel11, _numeroLineasUtilizadas, distractoresNivel11_12, _numeroDistractoresUtilizados));

            break;
            case 12:
                _numeroLineasUtilizadas = 8;
                _numeroDistractoresUtilizados = 3;
                StartCoroutine(MostrarNuevaFigura(figurasNivel12,moldesNivel12, _numeroLineasUtilizadas, distractoresNivel11_12, _numeroDistractoresUtilizados));

            break;
            default:

                Debug.Log("Este nivel se encuenta en construccion");

            break;

        }

    }

    //Metodo para llenar lista de opciones de figuras
    void LlenarSelectorFiguras(int numeroFiguras){
        for (int i = 0; i < numeroFiguras; i++){
            _selectorFiguras.Add(i);
        }
    }

    //Metodo para llenar lista de opciones de lineas y sus colores
    void LlenarSelectorLineas_Colores( int numeroLineas){
        for (int i = 0; i < numeroLineas; i++){
            _selectorLineas.Add(i);
            _selectorColores.Add(i);
        }
    }

    //Metodo para mostrar el orden en que se construyen las figuras y
    //acomodar las lineas despues de mostrar la secuencia
    IEnumerator MostrarNuevaFigura(GameObject[] figurasNivel,GameObject[] moldesNivel, int numeroLineas, GameObject[] distractoresNivel, int numeroDisctractores){
        
        LlenarSelectorLineas_Colores(numeroLineas);
        _selectorPosiciones.Clear();

        for (int i = 0; i< posicionesParaLineas.Count(); i++){
            _selectorPosiciones.Add(i);
        }

        for (int i = 0; i< distractoresNivel.Count(); i++){
            _selectorDistractores.Add(i);
        }

        yield return new WaitForSeconds(4f);
        avisosPanel.SetActive(false);
        //Se utiliza un panel transparente para evitar que el usuario trate
        //de levantar las lineas mientras se muestra la secuencia
        bloqueoClicksPanel.SetActive(true);

        if (_selectorFiguras.Count() <= 0){
            LlenarSelectorFiguras(figurasNivel.Count());
        }
        
        //Se elige figura aleatoria que no se repite con respecto a la
        //anterior secuencia junto con su molde
        int temporalFiguras = _numeroAleatorio.Next(0, _selectorFiguras.Count());
        if (_selectorFiguras[temporalFiguras] == _ultimaFiguraUtilizada && temporalFiguras < figurasNivel.Count()-1 ){
            temporalFiguras++;
        }
        else if (_selectorFiguras[temporalFiguras] == _ultimaFiguraUtilizada)
        {
            temporalFiguras = 0;
        }

        _ultimaFiguraUtilizada = _selectorFiguras[temporalFiguras];
        _figuraElegida = figurasNivel[_selectorFiguras[temporalFiguras]];
        _moldeElegido = moldesNivel[_selectorFiguras[temporalFiguras]];
        _selectorFiguras.RemoveAt(temporalFiguras);

        _figuraElegida.SetActive(true);
        
        //Se elige el orden de las lineas de la figura de forma aleatoria
        for( int i = 0; i < numeroLineas; i++){
            int temporalLineas = _numeroAleatorio.Next(0,_selectorLineas.Count());
            int idLineaElegida = _selectorLineas[temporalLineas];
            _selectorLineas.RemoveAt(temporalLineas);
            _respuestaEsperada.Add(idLineaElegida);
        }   
        
        //Se muestran las lineas que van apareciendo de colores aleatorios
        if (_nivel == 3 || _nivel == 4 || _nivel == 7 || _nivel == 8 || _nivel >= 11)            
            _selectorColores.Clear();

        foreach (int idLinea in _respuestaEsperada){
            GameObject lineaElegida = _figuraElegida.transform.GetChild(idLinea).gameObject;
            if (_nivel == 3 || _nivel == 4 || _nivel == 7 || _nivel == 8 || _nivel >= 11){               
                lineaElegida.GetComponent<Image>().color = Color.black;
                lineaElegida.SetActive(true);
                yield return new WaitForSeconds(1f);
                //lineaElegida.GetComponent<Image>().color = Color.black;
            }
            else{                        
                int indice = _numeroAleatorio.Next(0, _selectorColores.Count());
                int colorDeLinea = _selectorColores[indice];
                switch(colorDeLinea){
                    case 0:
                        lineaElegida.GetComponent<Image>().color = Color.red;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);                        
                    break;                    
                    case 1:
                        lineaElegida.GetComponent<Image>().color = Color.yellow;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;                    
                    case 2:
                        lineaElegida.GetComponent<Image>().color = Color.blue;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;
                    
                    case 3:
                        lineaElegida.GetComponent<Image>().color = Color.gray;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;
                    
                    case 4:
                        lineaElegida.GetComponent<Image>().color = Color.black;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;
                    
                    case 5:
                        lineaElegida.GetComponent<Image>().color = Color.magenta;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;
                    
                    case 6:
                        lineaElegida.GetComponent<Image>().color = new Color(1.0f, 0.64f, 0.0f);
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;
                    
                    case 7:
                        lineaElegida.GetComponent<Image>().color = Color.green;
                        lineaElegida.SetActive(true);
                        yield return new WaitForSeconds(1f);
                    break;

                    default:
                        lineaElegida.GetComponent<Image>().color = Color.black;
                        lineaElegida.SetActive(true);
                    break;

                }
            _selectorColores.RemoveAt(indice);

            }
        }

        avisosPanel.SetActive(true);

        //Se mueven las lineas a posiciones predefinidas de forma aleatoria
        //y sin repetirse, las posiciones elegidas se guardan en la lista
        //_posicionesElegidas
        for(int idLinea = 0; idLinea < numeroLineas; idLinea++){
            
            GameObject lineaElegida = _figuraElegida.transform.GetChild(idLinea).gameObject;
            int temporalPosiciones = _numeroAleatorio.Next(0,_selectorPosiciones.Count());
            _posicionesElegidas.Add(posicionesParaLineas[_selectorPosiciones[temporalPosiciones]]);
            lineaElegida.transform.position = posicionesParaLineas[_selectorPosiciones[temporalPosiciones]].transform.position;
            _selectorPosiciones.RemoveAt(temporalPosiciones);
            lineaElegida.GetComponent<Collider>().enabled = true;
        }

        //Se acomodan distractores
        
        for(int idDistractor = 0; idDistractor < numeroDisctractores; idDistractor++){
            
            int temporalPosiciones = _numeroAleatorio.Next(0,_selectorPosiciones.Count());
            int temporalDistractores = _numeroAleatorio2.Next(0,_selectorDistractores.Count());
            GameObject distractorElegido = distractoresNivel[_selectorDistractores[temporalDistractores]];
            _distractoresElegidos.Add(distractorElegido);
            distractorElegido.transform.position = posicionesParaLineas[_selectorPosiciones[temporalPosiciones]].transform.position;
            _selectorPosiciones.RemoveAt(temporalPosiciones);
            _selectorDistractores.RemoveAt(temporalDistractores);
            distractorElegido.SetActive(true);
            distractorElegido.GetComponent<Collider>().enabled = true;
        }


        //Se avisa que va a comenzar el ejercicio
        avisosText.text = "Acomoda las líneas en el orden que se mostró";
        yield return new WaitForSeconds(4f);
        avisosPanel.SetActive(false);
        bloqueoClicksPanel.SetActive(false);

        //Comienza el ejercicio
        _moldeElegido.SetActive(true);

    }



    bool CompararListas(List<int> lista1, List<int> lista2){        
        bool _iguales = true;
        int _indice = 0;
        if (lista1.Count != lista2.Count)
            _iguales = false;
        else
        {
            do
            {
                if (lista1[_indice] != lista2[_indice])                
                    _iguales = false;
                _indice++;
            } while (_indice < lista1.Count && _iguales);
        }
        return _iguales;
    }

    //Metodo para confirmar que la respuesta esta bien usando el boton de 
    //listo
    void RevisarRespuesta(){        
        //Se regresan las lineas a sus posiciones originales y se desactivan 
        //tanto la figura a la que corresponden como su molde asignado
        botonListo.enabled = false;
        botonBorrar.enabled = false;
        for (int idLinea = 0; idLinea < _numeroLineasUtilizadas; idLinea++){
            GameObject lineaElegida = _figuraElegida.transform.GetChild(idLinea).gameObject;
            lineaElegida.GetComponent<Collider>().enabled = false;
            lineaElegida.GetComponent<LineaScript>()._puedoArrastrar = true;
            GameObject lineaMoldeElegido = _moldeElegido.transform.GetChild(idLinea).gameObject;
            lineaElegida.transform.position = lineaMoldeElegido.transform.position;
            lineaElegida.SetActive(false);

        }

        //Se desactivan distractores
        foreach(GameObject distractor in _distractoresElegidos){
            distractor.SetActive(false);
        }

        _figuraElegida.SetActive(false);
        _moldeElegido.SetActive(false);
        _distractoresElegidos.Clear();

        if (CompararListas(_respuestaEsperada, _respuestaJugador)){
            _aciertos++;
            GuardaPartida(true,false);
            StartCoroutine(MostrarCorrecto());

        }
        else{
            _errores++;
            GuardaPartida(false, false);
            StartCoroutine(MostrarIncorrecto());
        }

    }

    //Metodo para mostrar que el usuario acerto y cambiar valores de la forma
    //que corresponda
    IEnumerator MostrarCorrecto(){
        if (_aciertos + _errores < 5){
            correctoPanel.SetActive(true);
            bocina.clip = victoria_audioclip;
            bocina.Play();
            yield return new WaitForSeconds(2f);
            correctoPanel.SetActive(false);
        }
        else{
            _selectorFiguras.Clear();
            _ultimaFiguraUtilizada = -1;
            if (_aciertos < 2){                
                regresaNivelPanel.SetActive(true);           
            }
            else if (_aciertos < 4){                
                mismoNivelPanel.SetActive(true);
            }
            else {
                bocina.clip = subeNivel_audioclip;
                bocina.Play();
                siguienteNivelPanel.SetActive(true);
                if (_nivel < 12)
                    _nivel++;
                else    
                    _nivel = 12;
            }
            _aciertos = 0;
            _errores = 0;            
            yield return new WaitForSeconds(4f);
            siguienteNivelPanel.SetActive(false);
            regresaNivelPanel.SetActive(false);
            mismoNivelPanel.SetActive(false);
        } 
        SeleccionarNivel();
    }

    //Metodo para mostrar que el usuario se equivoco y cambiar valores de la forma
    //que corresponda
    IEnumerator MostrarIncorrecto(){
        if ( _aciertos + _errores < 5){
            incorrectoPanel.SetActive(true);
            bocina.clip = derrota_audioclip;
            bocina.Play();
            yield return new WaitForSeconds(2f);
            incorrectoPanel.SetActive(false);
        }
        else{

            _selectorFiguras.Clear();
            _ultimaFiguraUtilizada = -1;
            if (_aciertos < 2){
                bocina.clip = bajaNivel_audioclip;
                bocina.Play();
                regresaNivelPanel.SetActive(true);
                
                if (_nivel > 1)
                    _nivel--;

                else    
                    _nivel = 1;

            }
            else if (_aciertos < 4){
                
                mismoNivelPanel.SetActive(true);
            }
            else {
                bocina.clip = subeNivel_audioclip;
                bocina.Play();
                siguienteNivelPanel.SetActive(true);
                if (_nivel < 12)
                    _nivel++;

                else    
                    _nivel = 12;

            }
            _aciertos = 0;
            _errores = 0;
            
            yield return new WaitForSeconds(4f);
            siguienteNivelPanel.SetActive(false);
            regresaNivelPanel.SetActive(false);
            mismoNivelPanel.SetActive(false);

        } 

        SeleccionarNivel();

    }


    //Metodo para borrar valores de la respuesta del jugador con el boton
    //de borrar
    void Borrar(){

        int lineaBorrada = _respuestaJugador[_respuestaJugador.Count()-1];
        GameObject lineaElegida = _figuraElegida.transform.GetChild(lineaBorrada).gameObject;
        lineaElegida.transform.position = _posicionesElegidas[lineaBorrada].transform.position;
        lineaElegida.GetComponent<LineaScript>()._puedoArrastrar = true;
        _respuestaJugador.RemoveAt(_respuestaJugador.Count()-1);

        if (_respuestaJugador.Count() == 0){

            botonBorrar.enabled = false;
            botonListo.enabled = false;

        }

    }

    public void Salir() {
        SceneManager.LoadScene("MenuConecta2");
    }

    public void GuardaPartida(bool victoria, bool agoto_tiempo)
    {
        Partida p = new Partida();
        p.nivel = _nivel;
        p.juego = "Conecta2";
        p.fecha = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        p.victoria = victoria;
        p.agoto_tiempo = agoto_tiempo;
        StartCoroutine(AduanaCITAN.SubePartidaA_CITAN(p));
    }

}
