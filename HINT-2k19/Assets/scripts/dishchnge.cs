using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dishchnge : MonoBehaviour
{

    public GameObject[] myDishes;
    public Button next;
    public Button previous;
    private int dishNumber = 0;
    public int numberOfDishes=3;


    // Start is called before the first frame update
    void Start()
    {
        //myDishes = new GameObject[3];
        for(int i=0;i<numberOfDishes;i++)
        {
            if(i==0)
            {
                myDishes[i].SetActive(true);
            }
            else
            {
                myDishes[i].SetActive(false);
            }
        }
        next.onClick.AddListener(nextDish);
        previous.onClick.AddListener(prevDish);
    }

    void nextDish()
    {
        dishNumber++;
        dishNumber = dishNumber % 3;
        for(int i=0;i<numberOfDishes;i++)
        {
            if(i==dishNumber)
            {
                myDishes[i].SetActive(true);
            }
            else
            {
                myDishes[i].SetActive(false);
            }
        }
    }

    void prevDish()
    {
        dishNumber--;

        if(dishNumber<0)
        {
            dishNumber = numberOfDishes - 1;
        }
        for (int i = 0; i < numberOfDishes; i++)
        {
            if (i == dishNumber)
            {
                myDishes[i].SetActive(true);
            }
            else
            {
                myDishes[i].SetActive(false);
            }
        }
    }
}
