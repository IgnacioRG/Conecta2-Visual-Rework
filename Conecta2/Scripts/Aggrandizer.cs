using UnityEngine;

//Script para aumentar el tamaño de los BoxCollider de las lineas distractoras.
public class Aggrandizer : MonoBehaviour
{
    public GameObject figuras_lines;
    public GameObject distractoras_lines;

    private void Awake()
    {
        FormatoDistractoras(20, 10);
    }

    /**
     * FormatoDistractoras Recorre los hijos de los objetos de juego que contienten
     * las lineas distractoras de los niveles.
     */
    private void FormatoDistractoras(int wth, int hgh)
    {
        for (int i = 0; i < distractoras_lines.transform.childCount; i++)
        {
            for (int j = 0; j < distractoras_lines.transform.GetChild(i).childCount; j++)
            {
                GameObject linea = distractoras_lines.transform.GetChild(i).GetChild(j).gameObject;
                float wline = linea.GetComponent<RectTransform>().rect.width;
                linea.GetComponent<RectTransform>().sizeDelta = new Vector2(wline + wth, hgh);
                linea.GetComponent<BoxCollider>().size = new Vector2(wline + wth, hgh);
            }
        }
    }

    /**
     * AgrandizzaElJocco permite escalar todas las figuras del juego sumando el ampliado.
     * 
     *  *Este metodo puede ocacionar colisiones no deseadas con las lineas interactuables o los
     *   botones de la escena.
     */
    private void AggrandizaElJocco(int amp)
    {
        for (int i = 0; i < figuras_lines.transform.childCount; i++)
        {
            for (int j = 0; j < figuras_lines.transform.GetChild(i).childCount; j++)
            {
                GameObject fig = figuras_lines.transform.GetChild(i).GetChild(j).gameObject;
                float escalax = fig.GetComponent<RectTransform>().rect.x;
                float escalay = fig.GetComponent<RectTransform>().rect.y;

                fig.GetComponent<RectTransform>().localScale = new Vector2(escalax + amp, escalay + amp);
            }
        }
    }
}

