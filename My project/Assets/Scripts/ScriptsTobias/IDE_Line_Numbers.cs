using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IDE_Line_Numbers : MonoBehaviour
{

    public TextMeshProUGUI IdeInput;
    public TextMeshProUGUI LineNumbersField;

    private int totalLineNum = 0;
    private int lastUpdateTotalLineNum = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalLineNum = IdeInput.textInfo.lineCount;

        if(totalLineNum != lastUpdateTotalLineNum)
        {
            Debug.Log(totalLineNum);
            lastUpdateTotalLineNum = totalLineNum;
            OutputLineNum();
        }

    }

    void OutputLineNum()
    {
        int tempLineNum = 1;
        string tempString = "";
        string lineNumText = "";

        for(int i = 0; i < totalLineNum; i++) { 

            tempString = tempLineNum.ToString() + "\n";
            lineNumText = lineNumText + tempString;
            tempLineNum++;
            
        }

        LineNumbersField.text = lineNumText;

    }
}