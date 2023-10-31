using UnityEngine;

public class Aggrandizer : MonoBehaviour
{
    public GameObject figuras_lines;
    public GameObject distractoras_lines;

    private void Awake()
    {
        AgrandizaElJocco(50,10);
    }

    private void AgrandizaElJocco(int wth, int hgh)
    {
        for (int i = 0; i < figuras_lines.transform.childCount; i++)
        {
            for (int j = 0; j < figuras_lines.transform.GetChild(i).childCount; j++)
            {
                for (int k = 0; k < figuras_lines.transform.GetChild(i).GetChild(j).childCount; k++)
                {
                    GameObject linea = figuras_lines.transform.GetChild(i).GetChild(j).GetChild(k).gameObject;
                    float wline = linea.GetComponent<RectTransform>().rect.width;
                    //linea.GetComponent<RectTransform>().sizeDelta = new Vector2(wline + wth, hgh);

                    linea.GetComponent<BoxCollider>().size = new Vector2(wline + wth, hgh);
                    
                }
            }
        }
    }
}
