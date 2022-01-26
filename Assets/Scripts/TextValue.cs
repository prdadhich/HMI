using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;




public class TextValue : MonoBehaviour
{
    public Renderer render;
    public TMP_Text text;
    private void Update()
    {
       int progress= (int)render.material.GetFloat("_adjustProgress");

        text.text = progress.ToString();
    }


}
