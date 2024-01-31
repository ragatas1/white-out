using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public GameObject dot;
    public GameObject Image;

    string TextToType = "Hva faen var det?";
    string IngenText = "Vent her jeg kommer snart tilbake.";

    public TMP_Text subtitleTextMesh;
    public TMP_Text text;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(PeterSnakker());
    }

    IEnumerator PeterSnakker()
    {
        yield return new WaitForSeconds(9.3f);
        dot.SetActive(true);

        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < TextToType.Length; i++)
        {
            subtitleTextMesh.text += TextToType[i];
            yield return new WaitForSeconds(0.05f);
        }
        
        
        yield return new WaitForSeconds(3.8f);

        dot.SetActive(false);
        Destroy(subtitleTextMesh);

        yield return new WaitForSeconds(2.6f);
        dot.SetActive(true);

        for (int i = 0; i < IngenText.Length; i++)
        {
            text.text += IngenText[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;

        yield return new WaitForSeconds(1);
        dot.SetActive(false);
        Image.SetActive(true);
        Destroy(text);
        yield return new WaitForSeconds(17);
        SceneManager.LoadScene("Emilie");

    }
}
