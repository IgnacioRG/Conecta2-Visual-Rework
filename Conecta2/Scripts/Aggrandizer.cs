using UnityEngine;

//Script para aumentar el tamaño de los BoxCollider de las lineas distractoras.
public class Aggrandizer : MonoBehaviour
{
    public GameObject distractoras_lines;

    private void Awake()
    {
        AgrandizaElJocco(20, 10);
    }

    /**
     * AgrandizaElJocco Recorre los hijos de los objetos de juego que contienten
     * las lineas distractoras de los niveles.
     */
    private void AgrandizaElJocco(int wth, int hgh)
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
}

