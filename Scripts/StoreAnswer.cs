using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAnswer : MonoBehaviour
{
    public string input;
    public bool correct;

    // DisplayAnswerOnScreen AnswerClass = new DisplayAnswerOnScreen();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string input){
        Debug.Log("Inside store answer readstringinput");
        // Debug.Log(AnswerClass.answer);
        this.input = input;
        Debug.Log(input);
    }
}
