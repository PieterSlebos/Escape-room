/*// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// using Microsoft.CSharp;
// using System.CodeDom;
// using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;

public class Compile : MonoBehaviour
{

    public Button compileButton;
    public TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = compileButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Knoppie doet t hoor");
        Debug.Log(textField.text);

        ExecuteScript(textField.text);
    }

    public void ExecuteScript(string input)
    {
        try
        {
            string inputSript = GetStript(input);
            var scriptOptions = ScriptOptions.Default.AddReferences("CSCodeExecuter");

            var result = Execute(inputSript, scriptOptions);

            Debug.Log(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private string GetStript(string input)
    {

        string csSript =
            @"
                public class ScriptedClass
                {
                    public ScriptedClass()
                    {
                        " + input + @"
                    }
                }

                return (new ScriptedClass()).input;";

        return csSript;
    }

    private static ScriptState<object> scriptState = null;

    public static object Execute(string code, dynamic scriptOptions)
    {
        scriptState = scriptState == null ? CSharpScript.RunAsync(code, scriptOptions).Result : scriptState.ContinueWithAsync(code).Result;

        if (scriptState.ReturnValue != null && !string.IsNullOrEmpty(scriptState.ReturnValue.ToString()))
            return scriptState.ReturnValue;
        return null;
    }

    // Update is called once per frame  
*//*    void Update()
    {

    }*//*

}
*/