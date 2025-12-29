using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [Header("Falas")]
    //dado Tipado <T>
    public List<string> falas = new List<string>();
    int currentLine;

    public Dialogo scriptableDoDialogo;
    //string currentLine;//cópia linha atual*!

    [Header("Referencias")]
    [SerializeField] TextMeshProUGUI texto;

    void Start()
    {
        falas = scriptableDoDialogo.dialogueLines;

        currentLine = 0;
        texto.text = falas[currentLine];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TocarProximaFala();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            TocarFalaAnterior();
        }
    }
    public void TocarProximaFala()
    {
        if (currentLine >= falas.Count - 1)
        {
            //cheguei no fim válido da lista de falas
            //fecha o painel se tentar avançar de novo
            return;
        }//non-nested coding
        currentLine++;
        texto.text = falas[currentLine];
    }
    public void TocarFalaAnterior()
    {
        if (currentLine <= 0)
        {
            return;
        }
        currentLine--;
        texto.text = falas[currentLine];
    }
}

/*
 public DialogueScriptable dialogue;
    TextMeshProUGUI textComponent;

    int lineIndex = 0;//contador de linha
    

string currentLine;//cópia linha atual*!


    string[] lines;//uma cópia da lista que o scriptableObject tem

    IEnumerator Start()//:O
    {
        textComponent = GetComponentInChildren<TextMeshProUGUI>();
        yield return new WaitUntil(() => textComponent != null);
        Debug.Log($"Texto pronto pra uso!");
        yield return new WaitForSeconds(0.5f);
        textComponent.text = string.Empty;
        yield return new WaitForSeconds(0.5f);
        StartDialogue();
    }
    void StartDialogue()
    {
        lineIndex = 0;//reseta o contador de linha


        lines = dialogue.GetLines();//anota as falas que vai usar
        StartCoroutine(TypeDialogueRoutine());//comeca a coroutine de dialogo
    }
    IEnumerator TypeDialogueRoutine()
    {
        //currentLine = dialogue.GetDialogue();
        //char[] letters = currentLine.ToCharArray();

        //foreach (char letter in letters)
        //{
        //    textComponent.text += letter;
        //    yield return new WaitForSeconds(dialogue.textSpeed);
        //}char -> character
        foreach (char c in lines[lineIndex].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(dialogue.textSpeed);
        }
    }
 */