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
        questions.Add("1. �El alcohol es legal en todos los pa�ses del mundo? (Verdadero)");
        questions.Add("2. �El tabaco es ilegal para personas menores de 18 a�os en la mayor�a de los pa�ses? (Verdadero)");
        questions.Add("3. �La coca�na es legal en algunos pa�ses para uso recreativo? (Falso)");
        questions.Add("4. �La marihuana medicinal est� legalizada en varios pa�ses? (Verdadero)");
        questions.Add("5. �El �xtasis es una droga alucin�gena? (Falso)");
        questions.Add("6. �La nicotina es la sustancia adictiva presente en el tabaco? (Verdadero)");
        questions.Add("7. �Los opi�ceos incluyen la hero�na y la morfina? (Verdadero)");
        questions.Add("8. �Los alucin�genos pueden causar alucinaciones visuales y auditivas?(Verdadero)");
        questions.Add("9. �El consumo de alcohol puede provocar da�os en el h�gado a largo plazo? (Verdadero)");
        questions.Add("10. �La metanfetamina es una droga estimulante? (Verdadero)");
        DisplayRandomQuestion();
    }

    void DisplayRandomQuestion()
    {
        int randomIndex = Random.Range(0, questions.Count);
        textMeshPro.text = questions[randomIndex];
    }
}
