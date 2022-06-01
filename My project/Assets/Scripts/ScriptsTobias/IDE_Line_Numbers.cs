using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IDE_Line_Numbers : MonoBehaviour
{

    public TextMeshProUGUI IdeInput;
    public TextMeshProUGUI LineNumbersField;

    private int _totalLineNum;

    // Update is called once per frame
    void Update()
    {
        if (_totalLineNum < IdeInput.textInfo.lineCount)
        {
            _totalLineNum += 1;
            LineNumbersField.text += _totalLineNum + "\n";
        }
    }
}