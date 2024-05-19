using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<string> questions = new List<string>();
    public TextMeshPro textMeshPro;

    void Start()
    {
        questions.Add("1. ¿El alcohol es legal en todos los países del mundo? (Verdadero)");
        questions.Add("2. ¿El tabaco es ilegal para personas menores de 18 años en la mayoría de los países? (Verdadero)");
        questions.Add("3. ¿La cocaína es legal en algunos países para uso recreativo? (Falso)");
        questions.Add("4. ¿La marihuana medicinal está legalizada en varios países? (Verdadero)");
        questions.Add("5. ¿El éxtasis es una droga alucinógena? (Falso)");
        questions.Add("6. ¿La nicotina es la sustancia adictiva presente en el tabaco? (Verdadero)");
        questions.Add("7. ¿Los opiáceos incluyen la heroína y la morfina? (Verdadero)");
        questions.Add("8. ¿Los alucinógenos pueden causar alucinaciones visuales y auditivas?(Verdadero)");
        questions.Add("9. ¿El consumo de alcohol puede provocar daños en el hígado a largo plazo? (Verdadero)");
        questions.Add("10. ¿La metanfetamina es una droga estimulante? (Verdadero)");
        DisplayRandomQuestion();
    }

    void DisplayRandomQuestion()
    {
        int randomIndex = Random.Range(0, questions.Count);
        textMeshPro.text = questions[randomIndex];
    }
}
