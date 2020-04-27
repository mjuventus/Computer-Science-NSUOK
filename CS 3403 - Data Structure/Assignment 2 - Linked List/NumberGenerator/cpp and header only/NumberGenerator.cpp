// NumberGenerator.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <random>
#include <fstream>
#include <ctime>


#include "ListNode.h";

using namespace std;
void CreateTxtFile();
void GenerateRandomArray();
void writeRandomArray();
void printUnsorted();
void sortArray();
void WriteSortedArray();
void printSorted();
void EliminateDupe();
void printEliminate();
void linkedList();
void WritetoFileFinal();



int main()
{
    CreateTxtFile();

    //Main Program
    {



        std::cout << "Random number generated (saved in array): " << endl << endl;


        //generating random number and storing it in an array
        GenerateRandomArray();
        writeRandomArray();
        printUnsorted();



        sortArray();
        WriteSortedArray();

        writeFile << "\n \n \n Numbers will be sorted, and the duplicate numbers will be eliminated,";
        writeFile << "\n changed into a new random number, then being sorted again.\n";
        writeFile << "\n Program will keep sorting and eliminating duplicates until the numbers";
        writeFile << "\n are sorted right without any duplicate. \n \n";

        cout << "\n \n \n Numbers will be sorted, and the duplicate numbers will be eliminated,";
        cout << "\n changed into a new random number, then being sorted again.\n";
        cout << "\n Program will keep sorting and eliminating duplicates until the numbers";
        cout << "\n are sorted right without any duplicate. \n \n";
        
        
    //loop  (this loop will keep sorting the numbers and eliminate the duplicate numbers until there's no more duplicate in sorted numbers  
        int notRight = 1;
        do
        {

            EliminateDupe();
            sortArray();
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                if (numberArray[i] >= numberArray[i + 1])
                {
                    notRight++;
                }
            }
            notRight--;
        }
            while (notRight > 0);

        printSorted();


    }





    //moving first number from array to linked list

    cout << endl << endl << endl;
    cout << endl << endl << endl << "Numbers above will be saved in linked list (nodes): " << endl;

    //Linked List function

    cout << "Below are the numbers saved in linked list: \n";
    writeFile << "Below are the numbers saved in linked list: \n";
    linkedList();
    cout << endl << endl << endl << endl << endl;
    writeFile << endl << endl << endl << endl << endl;



    WritetoFileFinal();

   








    //ending program
    system("pause");
    return 0;
}



void GenerateRandomArray(){
    srand(time(0));
    for (int i = 0; i < sizeOfArray; i++)
    {

        numberArray[i] = rand() % 58;
        std::cout << numberArray[i] << " ";
    }
}
void writeRandomArray()
{
    writeFile << "Random number Generated: " << endl;
    for (int i = 0; i < sizeOfArray; i++)
    {
        writeFile << endl << numberArray[i];
    }
}
void printUnsorted() {
    cout << endl << endl << endl << "unsorted array: " << endl;

    for (int i = 0; i < sizeOfArray; i++)
    {

        printf("%d \n", numberArray[i]);

    }
}


void sortArray()
{

    

    while (1) {
        SwapNumber = 0;
        for (int i = 0; i < sizeOfArray - 1; i++)
        {
            if (numberArray[i] > numberArray[i + 1])
            {
                int temporaryNumber = numberArray[i];
                numberArray[i] = numberArray[i + 1];
                numberArray[i + 1] = temporaryNumber;
                SwapNumber = 1;
            }
        }


        if (SwapNumber == 0) {
            break;
        }




    }
    
}
void printSorted() {
    printf("\n \n Sorted List\n");

    for (int i = 0; i < sizeOfArray; i++)
    {

        printf("%d \n", numberArray[i]);

    }
}
void WriteSortedArray()
{
    writeFile << "\n \n Sorted list (duplicates are not eliminated yet): " << endl;
    for (int i = 0; i < sizeOfArray; i++)
    {
        writeFile << endl << numberArray[i];
    }
}


void EliminateDupe()
{
    
    for (int i = 1; i < sizeOfArray; i++)
    {

        if (numberArray[i] == numberArray[i - 1])
        {
            numberArray[i] = rand() % 58;

        }
        ;
    }
}
void printEliminate() {
    printf(" \n \n \n eliminating dupes: \n \n");
    for (int i = 1; i < sizeOfArray; i++)
    {
        printf("%d \n", numberArray[i]);
    }
}




void linkedList()
{

    {
        newNode = new ListNode;
        newNode->data = numberArray[0];
        temporary = newNode;
        head = newNode;

        cout << endl << newNode->data << " ";
        writeFile << endl << newNode->data << " ";
    }

    //moving the rest of the numbers from array to linked list
    for (int u = 1; u < sizeOfArray; u++)
    {
        newNode = new ListNode;
        newNode->data = numberArray[u];
        temporary->next = newNode;
        temporary = temporary->next;

        cout << newNode->data << " ";
        writeFile << newNode->data << " ";
    }

    //ending the linked list
    newNode->next = NULL;


}




void CreateTxtFile()
{
    
    writeFile.open("randomnumber.txt"); // read from file located in c:/temp 
    return;
}

void WritetoFileFinal()
{
    writeFile << "Array Size: " << sizeOfArray << endl;
    writeFile << "Sorted list without any duplicates: " << endl;
    for (int i = 0; i < sizeOfArray; i++)
    {
        writeFile << endl << numberArray[i];
    }

    writeFile.close();
}