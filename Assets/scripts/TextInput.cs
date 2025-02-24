﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour {

    public InputField inputField;

    private GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

	void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        controller.LogStringWithReturn(userInput);

        char[] delimiterCharacters = { ' ' };
        string[] separatedInputWords = userInput.Split(delimiterCharacters);

        /*if(separatedInputWords[0].Equals("quit"))
        {
            Application.Quit();
        }*/

        for (int i = 0; i < controller.inputActions.Length; i++)
        {
            InputAction inputAction = controller.inputActions[i];
            if (inputAction.keyWord == separatedInputWords[0])
            {
                inputAction.RespondToInput(controller, separatedInputWords);
            }
        }

        InputComplete();
    }

    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;

    }
}
