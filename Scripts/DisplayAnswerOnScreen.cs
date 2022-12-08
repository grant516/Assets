using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// using Firebase.RemoteConfig;
using System.Threading.Tasks;


public class DisplayAnswerOnScreen : MonoBehaviour
{
    // UI Text GameObjects
    public GameObject Question;
    public GameObject inputField;
    
    // Game Variables
    public string question;

    // Text Components -- this is the actual boxes of text not
    //just the element
    TextMeshProUGUI question_data;


    private void Awake() {
        
    }

    
    // Start is called before the first frame update
    void Start(){
        question_data = Question.GetComponent<TextMeshProUGUI>();
        // question_data.text = "please fr please";
        string[] returnedList = GenerateQuestion();
        question_data.text = returnedList[0] + " " + "= "+ returnedList[1];

        int answer = System.Int32.Parse(returnedList[1]);
    }
        

    // Update is called once per frame
    void Update()
    {
        // question_data.text = question;   
    }


    public string[] GenerateQuestion(){
        // Random random = new Random();
        int answer = 0;
        char[] operators = new char[4]{'+', '-', '*', '/'};

        int num1 = Random.Range(0,25);
        int num2 = Random.Range(1,25);

        char op = operators[Random.Range(0,operators.Length)];

        if(op == '+')
            answer = num1 + num2;
        else if(op == '-')
            answer = num1 - num2;
        else if(op == '*')
            answer = num1 * num2;
        else if(op == '/'){
            num1 = num1 * num2 * (Random.Range(1,5));
            answer = num1 / num2;
        }

        question = $"{num1} {op} {num2}";
        string[] returnList = new string[2]{question, answer.ToString()};

        return returnList;
    }


}
