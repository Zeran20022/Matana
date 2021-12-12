using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string TasK;
    public string Answers;
    public Text Tesk;
    public Text a1;
    public Text a2;
    public Text a3;
    public Text a4;
    public Text a5;
    public Text a6;
    public Text a7;
    public Text a8;
    public Text a9;
    public Text a10;

    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        TasK = s[0];
        Answers = s[1];
        Tesk.text = TasK;
        string[] A = Answers.Split(';');
        a1.text = A[0];
        a2.text = A[1];
        a3.text = A[2];
        a4.text = A[3];
        a5.text = A[4];
        a6.text = A[5];
        a7.text = A[6];
        a8.text = A[7];
        a9.text = A[8];
        a10.text = A[9];
    }
}
