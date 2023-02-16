using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangmanGame : MonoBehaviour
{
    private List<string> guessedKeys = new List<string>();
    
    private KeyCode lastKeyCode;
    
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
            
            if (e.keyCode != KeyCode.None)
            {
                ProcessKey(e.keyCode);

                KeyCode lastKeyPressed = e.keyCode;
            }
        }
    }

    private void ProcessKey(KeyCode key)
    {
        var word = "Time";

        print("Word to guess is: " + word);

        print("Key Pressed: " + key);

        string keyString = key.ToString();

        string wordUppercase = word.ToUpper;
        bool wordContainsPressedKey = word.Contains(keyString);
        bool letterWasGuessed = guessedKeys.Contains(keyString);

        print ("wordContainePressedKey: " + wordContainsPressedKey);

        if(wordContainsPressedKey && !letterWasGuessed)
        {
            guessedKeys.Add(keyString);
        }

        print(string.Join{", "}, guessedKeys);
    }
}
