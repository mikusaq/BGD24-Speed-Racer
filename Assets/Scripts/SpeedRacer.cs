using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker = "";
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);


    void Start()
    {
        print("The race model is " + carModel + " by " + carMaker + ". It has a " + engineType + "engine.");
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
        if(Input.GetKeyDown(KeyCode.Space)) {
            ConsumeFuel();
            CheckFuelLevel();
        }
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

    void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }

    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report");
                break;
        }
    }
}
