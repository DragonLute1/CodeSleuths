using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayManager : MonoBehaviour
{
    //refference to winning window
    public GameObject winCondition;

    //buttons to disable when the game is over
    public List<Button> buttons = new List<Button>();

    //text varaibles for the code answers
    public Text TextA;
    public Text TextB;
    public Text TextC;

    //ints to store the values of each value of i, offset for them to be proper in the array
    int i1 = 0;
    int i2 = 0;
    int i3 = 0;

    //bools to check what logic operations to perform
    bool lessThan = false;
    bool greaterThan = false;
    bool equals = false;

    public List<Image> array = new List<Image>();

    private void Awake()
    {
        for (int i = 0; i < array.Count; i++)
        {
            array[i].enabled = false;
        }
    }

    public void Run()
    {
        for (int i = 0; i < array.Count; i++)
        {
            array[i].enabled = false;
        }
        if (equals)
        {
            for(int i = i1; i == i2; i += i3)
            {
                //checks for inifinite loops
                
                if (i > 7)
                {
                    break;
                }
                if (i < 0)
                {
                    break;
                }
                array[i].enabled = true;
                if (i3 == 0)
                {
                    break;
                }
            }
        }else if (lessThan)
        {
            for (int i = i1; i < i2; i += i3)
            {
                //checks for infinite loops
                
                if (i > 7)
                {
                    break;
                }
                if (i < 0)
                {
                    break;
                }
                array[i].enabled = true;
                if (i3 == 0)
                {
                    break;
                }
            }

            //checks for correct solution
            if (i1 == 1 && i2 == 7 && i3 == 1)
            {
                //cycles through all buttons to turn them off
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].interactable = false;
                }
                //reveals the winning window
                winCondition.SetActive(true);
            }
        }else if (greaterThan)
        {
            for (int i = i1; i > i2; i += i3)
            {
                //checks for infinite loops
                
                if (i > 7)
                {
                    break;
                }
                if(i < 0)
                {
                    break;
                }
                array[i].enabled = true;
                if (i3 == 0)
                {
                    break;
                }
            }
        }
    }
    public void Answer1()
    {
        TextA.text = "i=0";
        i1 = 1;
    }

    public void Answer2()
    {
        TextA.text = "i=1";
        i1 = 2;
    }

    public void Answer3()
    {
        TextA.text = "i=7";
        i1 = 7;
    }

    public void Answer4()
    {
        TextA.text = "i=-1";
        i1 = 0; 
    }

    public void Answer5()
    {
        TextA.text = "i=6";
        i1 = 7;
    }

    public void Answer6()
    {
        TextB.text = "i>1";
        lessThan = false;
        equals = false;
        greaterThan = true;
        i2 = 2;
    }

    public void Answer7()
    {
        TextB.text = "i==1";
        equals = true;
        i2 = 2;
        lessThan = false;
        greaterThan = false;

    }

    public void Answer8()
    {
        TextB.text = "i<5";
        lessThan = true;
        greaterThan = false;
        equals = false;
        i2 = 6;
    }

    public void Answer9()
    {
        TextB.text = "i<6";
        lessThan = true;
        greaterThan = false;
        equals = false;
        i2 = 7;
    }

    public void Answer10()
    {
        TextB.text = "i<7";
        lessThan = true;
        greaterThan = false;
        equals = false;
        i2 = 8;
    }

    public void Answer11()
    {
        TextC.text = "i=i";
        i3 = 0;
    }

    public void Answer12()
    {
        TextC.text = "i=i+1";
        i3 = 1;
    }

    public void Answer13()
    {
        TextC.text = "i=i+2";
        i3 = 2;
    }

    public void Answer14()
    {
        TextC.text = "i=i-1";
        i3 = -1;
    }

    public void Answer15()
    {
        TextC.text = "i=i-2";
        i3 = -2;
    }

    public void Clear()
    {
        TextA.text = "";
        TextB.text = "";
        TextC.text = "";
        i1 = 0;
        i2 = 0;
        i3 = 0;
        lessThan = true;
        equals = false;
        for (int i = 0; i < array.Count; i++)
        {
            array[i].enabled = false;
        }
    }
}
