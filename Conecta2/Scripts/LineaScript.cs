using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LineaScript : MonoBehaviour
{

    public GameObject GameManager;

    private Vector3 _offSet, _posicionInicial, _posicionDestino;
    private float _z_coor;
    
    public bool _puedoArrastrar = true;
    private bool _enCollider = false;

    private void OnMouseDown() {
        _z_coor = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        _offSet = gameObject.transform.position - GetMouseWorldPos();
        _posicionInicial = transform.position;
        _posicionDestino = _posicionInicial;
    }

    private void OnMouseUp() {
        if(_puedoArrastrar == false)
            return;
        transform.position = _posicionDestino;
        
        
        if (_enCollider){
            
            _puedoArrastrar = false;

            GameManager.GetComponent<JuegoScript>().botonBorrar.enabled = true;
            GameManager.GetComponent<JuegoScript>().botonListo.enabled = true;


            if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea1)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(0);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea2)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(1);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea3)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(2);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea4)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(3);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea5)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(4);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea6)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(5);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea7)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(6);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea8)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(7);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea9)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(8);
            }
            else if (this.GetComponent<LineaMoldeScript>().tipo == LineaMoldeScript.TipoLinea.Linea10)
            {
                GameManager.GetComponent<JuegoScript>()._respuestaJugador.Add(9);
            }
        }
    }

    // Start is called before the first frame update
    private void Start()
    {

    }
 

   private Vector3 GetMouseWorldPos() {
        Vector3 mouseTemp = Input.mousePosition;
        mouseTemp.z = _z_coor;
        return Camera.main.ScreenToWorldPoint(mouseTemp);
    }

    private void OnMouseDrag() {
        if(_puedoArrastrar == false)
            return;
        transform.position = _offSet + GetMouseWorldPos();
    }

    void OnTriggerExit(Collider collider){

        
        if (collider.GetComponent<LineaMoldeScript>().tipo == this.GetComponent<LineaMoldeScript>().tipo){

            _posicionDestino = _posicionInicial;
            _enCollider = false;

        }
    }

    void OnTriggerEnter(Collider collider){
        
        if (collider.GetComponent<LineaMoldeScript>().tipo == this.GetComponent<LineaMoldeScript>().tipo){

            //this.GetComponent<Collider>().enabled= false;
            //_puedoArrastrar = false;
            _posicionDestino = collider.transform.position;
            _enCollider = true;
            //transform.position = collider.transform.position;

        }
    }
}
