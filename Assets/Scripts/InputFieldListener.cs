using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldListener : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    public void TestOnValueChanged()
    {
        print($"From changed event {inputField.text}");
    }

    public void TestOnEndEdit()
    {
        print($"From end event {inputField.text}");
    }

    private void Start()
    {
        inputField.onValueChanged.AddListener(delegate(string str)
        {
            print($"From CODE!!! changed event {str}");
        });
        inputField.onEndEdit.AddListener(delegate(string str)
        {
            print($"from CODE!!! end event {str}");
        });
    }
    
    
}
