using UnityEngine;

//Script para aumentar el tamaño de los BoxCollider de las lineas.
public class Aggrandizer : MonoBehaviour
{
    public GameObject figuras_lines;
    public GameObject distractoras_lines;

    private void Awake()
    {
        AgrandizaElJocco(10);
    }

    private void AgrandizaElJocco(int hgh)
    {
        for (int i = 0; i < figuras_lines.transform.childCount; i++)
        {
            for (int j = 0; j < figuras_lines.transform.GetChild(i).childCount; j++)
            {
                for (int k = 0; k < figuras_lines.transform.GetChild(i).GetChild(j).childCount; k++)
                {
                    GameObject linea = figuras_lines.transform.GetChild(i).GetChild(j).GetChild(k).gameObject;
                    float wline = linea.GetComponent<RectTransform>().rect.width;
                    linea.GetComponent<RectTransform>().sizeDelta = new Vector2(wline, hgh);
                    linea.GetComponent<BoxCollider>().size = new Vector2(wline, hgh);
                }
            }
        }
    }
}
