#include <iostream>
#include <string>
#include <random>
#include <fstream>
#include <ctime>


#include "ListNode.h";

using namespace std;

int main()
    {
        int arrayCounter, temporaryNumber, SwapNumber;
        const int howMany = 10;
        int goals[howMany];

        for (arrayCounter = 0; arrayCounter < howMany; arrayCounter++)
        {
            goals[arrayCounter] = (rand() % 25) + 1;

        }


        printf("Original List\n");

        for (arrayCounter = 0; arrayCounter < howMany; arrayCounter++)
        {
            printf("%d \n", goals[arrayCounter]);

        }

        while (1) {
            SwapNumber = 0;
            for (arrayCounter = 0; arrayCounter < howMany - 1; arrayCounter++)
            {
                if (goals[arrayCounter] > goals[arrayCounter + 1])
                {
                    int temporaryNumber = goals[arrayCounter];
                    goals[arrayCounter] = goals[arrayCounter + 1];
                    goals[arrayCounter + 1] = temporaryNumber;
                    SwapNumber = 1;
                }
            }


            if (SwapNumber == 0) {
                break;
            }




        }
        printf("\n \n Sorted List\n");

        for (arrayCounter = 0; arrayCounter < howMany; arrayCounter++)
        {
            printf("%d \n", goals[arrayCounter]);

        }


    }
   