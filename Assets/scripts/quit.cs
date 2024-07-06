using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text_Adventure/InputActions/quit")]
public class quit : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        Application.Quit();
    }
}