using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
   
{
    public Text title;
    public int min = 1;
    public int max = 1000;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        if (title !=null)
        {
            title.text = "Magic Numbers";
        }
        //min = 1;
        //max = 1000;
        title.color = Color.cyan;
        print(" Загадайте число от " + min + " до " +  max);
        

        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
       if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
       if (Input.GetKeyDown(KeyCode.Return))
        {
            print(" I'm a wizard, Harry ");
            Start();
        }
    }
    
    void UpdateGuess()
    {
        guess = (min + max) / 2;
        print(" Ваше число " + guess + " ? ");

    }
}
