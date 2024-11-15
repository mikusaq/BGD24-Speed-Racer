using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;
    void Start()
    {
        print("The race model is " + carModel + ". It has a " + engineType + "engine.");
        CheckWeight();
        if(yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int carAge = CalculateAge(yearMade);
            print("The age of the car is " + carAge + ".");
        }
        else
        {
            print("The car was introduced in the 2010's.");
            print("Max acceleration of the car is " + maxAcceleration + ".");
        }

        print("The car " + CheckCharacteristics() + ".");
    }

    void Update()
    {

    }

    void CheckWeight()
    {
        if(carWeight < 1500)
        {
            print("The car weight is less than 1500 kg.");
        }
        else
        {
            print("The car weight is over 1500 kg.");
        }
    }

    int CalculateAge(int year)
    {
        return 2023 - year;
    }

    string CheckCharacteristics()
    {
        if(isCarTypeSedan)
        {
            return "is sedan";
        }
        else if(hasFrontEngine)
        {
            return "is not a sedan, but has a front engine";
        }
        else
        {
            return "is not sedan and has not a front engine";
        }
    }
}
