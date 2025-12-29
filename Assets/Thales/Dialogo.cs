using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Novo Dialogo", menuName = "Scriptables/Dialogos", order = 0)]
public class Dialogo : ScriptableObject
{
    [TextArea] public List<string> dialogueLines;
    public Image characterPortrait;
}