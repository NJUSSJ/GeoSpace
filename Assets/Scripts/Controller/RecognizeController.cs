using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecognizeController : MonoBehaviour
{
    WritingPanel writingPanel;
    PenBehaviour penBehaviour;

    public void Init(WritingPanel writingPanel)
    {
        this.writingPanel = writingPanel;
    }

    public string GetRecognizeResult(string base64)
    {
        ///TODO
        return "s";
    }
}