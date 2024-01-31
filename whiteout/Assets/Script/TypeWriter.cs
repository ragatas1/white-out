using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public GameObject dot;
    string TextToType = "Hva faen var det?";
    string IngenText = "";

   public TMP_Text subtitleTextMesh;

    // Update is called once per frame
    void Start()
    {
 
        StartCoroutine(PeterSnakker());
    }

    IEnumerator PeterSnakker()
    {
        //yield return new WaitForSeconds(9);
        dot.SetActive(true);

        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < TextToType.Length; i++)
        {
            subtitleTextMesh.text += TextToType[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;

        yield return new WaitForSeconds(4);


        for (int i = 0; i < TextToType.Length; i++)
        {
            TextToType.Remove(i);
            i--;
        }


        yield return new WaitForSeconds(2);

        for (int i = 0; i < IngenText.Length; i++)
        {
            subtitleTextMesh.text += IngenText[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
    }
}
