// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;


struct Student
{
    int id;
    string firstname;
    string lastname;
    float gpa;
    string major;
};

int main()
{
    cout << "Hi! Welcome to MergeSort 0.3.0!\n";
    cout << endl << "To use this program, here is the rule: \n";
    cout << "1. Every list file must be in the right format (id number, first name, last name, gpa, major)\n";
    cout << "2. Lists must not have excessive line (means after the last student, there should not be extra Line(s)\n";
    cout << "3. Final List can contain maximum of 100 students\n\n\n\n";


    //Creating an output File
    ofstream outFile;
    cout << "Please enter the filename for Output with the extensions (Ex: FullList.txt): ";
    string outFileName;
    cin >> outFileName;
    outFile.open("Merged.dat");

    cout << endl << "Creating File..." << endl << endl << endl;


    //Finding the first input File
    ifstream File1;
    string fileName1;
    string String1;


    int fileOk = 0;
    bool fileOpened = false;
    while (fileOpened == false)
    {
        cout << "Please enter the first filename with the extensions (Ex: List1.txt): ";
        cin >> fileName1;
        File1.open(fileName1);

        cout << endl << "This file contains: \n\n";

        string TempStr;
        getline(File1, TempStr);
        cout << TempStr << endl << endl << endl;

        fileOk = 0;
        
        string fileOkInput;


        //Check if file is right

        while (fileOk == 0)
        {
            cout << endl << "Is this the right file? ";
            cin >> fileOkInput;
            if (fileOkInput == "y" || fileOkInput == "Y")
            {
                fileOk = 1;
                fileOpened = true;
                cout << endl << endl << "Processing Data..." << endl << endl;
            }
            else if (fileOkInput == "n" || fileOkInput == "N")
            {
                fileOk = 1;
                fileOpened = false;
                cout << endl << endl << "Make sure you have the right filename and the extension." << endl << endl;
                File1.close();
            }
            else
            {
                cout << endl << endl << "Invalid input, please enter Y or y for yes, N or n for no." << endl << endl;
                fileOk = 0;
                fileOpened = false;
            }
        }


    }

    //copy the first list into the output list
    cout << endl << endl << "File detected! \n \n";
    File1.close();
    File1.open(fileName1);
    while (!File1.eof())
    {
        string tempStr;
        getline(File1, tempStr);
        cout << tempStr << endl;
        outFile << tempStr << endl << endl << endl;
    }

    cout << endl << endl;
    File1.close();


    //Second File
    ifstream File2;
    string fileName2;
    string String2;


    fileOpened = false;
    int file1Ok = 0;
    while (fileOpened == false)
    {
        cout << "Please enter the second filename with the extensions (Ex: List2.txt): ";
        cin >> fileName2;
        File2.open(fileName2);

        cout << endl << "This file contains: \n\n";

        string TempStr;
        getline(File2, TempStr);
        cout << TempStr << endl;

        file1Ok = 0;
        
        string file1OkInput;


        //Check if file is right

        while (file1Ok == 0)
        {
            cout << endl << "Is this the right file? ";
            cin >> file1OkInput;
            if (file1OkInput == "y" || file1OkInput == "Y")
            {
                file1Ok = 1;
                fileOpened = true;
                cout << endl << endl << "Processing Data..." << endl << endl;
            }
            else if (file1OkInput == "n" || file1OkInput == "N")
            {
                file1Ok = 1;
                fileOpened = false;
                cout << endl << endl << "Make sure you have the right filename and the extension." << endl << endl;
                File1.close();
            }
            else
            {
                cout << endl << endl << "Invalid input, please enter Y or y for yes, N or n for no." << endl << endl;
                file1Ok = 0;
                fileOpened = false;
            }
        }


    }

    //copy the second list into the output list
    cout << endl << endl << "File detected! \n \n";
    File2.close();
    File2.open(fileName2);
    while (!File2.eof())
    {
        string tempStr;
        getline(File2, tempStr);
        cout << tempStr << endl;
        outFile << tempStr << endl;
    }


    cout << endl << endl;
    File2.close();

    cout << endl << endl << "New file created!" << endl << endl << endl;

    outFile.close();





    //make merged.dat as input and put the in string
    string studentData[100];
    int studentId[100];
    string tempStudentId;
    ifstream merged;
    merged.open("merged.dat");
    int totalLine = 0;

    Student details[100];

    while (!merged.eof())
    {
        for (int i = 0; i < 100; i++)
        {
            if (merged.eof())
            {
                break;
            }
            else
            {

                merged >> details[i].id >> details[i].firstname >> details[i].lastname >> details[i].gpa >> details[i].major;
                studentId[i] = details[i].id;
                cout << studentData[i] << endl;

                totalLine++;

            }

        }
    }


    totalLine--;
    cout << totalLine << " students data detected. " << endl;
    for (int i = 0; i < totalLine; i++)
    {
        cout << endl << endl;
        cout << "Student ID detected: " << details[i].id << endl;
        cout << "Student First Name: " << details[i].firstname << endl;
        cout << "Student Last Name: " << details[i].lastname << endl;
        cout << "Student GPA: " << details[i].gpa << endl;
        cout << "Student Major: " << details[i].major << endl;
    }




    //printing unsorted data
    cout << endl << endl << endl;
    cout << "The unsorted data is: " << endl;
    for (int i = 0; i < totalLine; i++)
    {
        cout << details[i].id << " " << details[i].firstname << " " << details[i].lastname << " " << details[i].gpa << " " << details[i].major << endl;
    }

    //sorting data by id
    Student temp;
    int sortingProcess = 0;
    bool justEdit = true;
    while (justEdit == true)
    {
    
        
        justEdit = false;

        //sorting process
        for (int i = 0; i < totalLine-1; i++)
        {
        
            
            if (details[i].id > details[i+1].id)
            {
                temp = details[i + 1];
                details[i + 1] = details[i];
                details[i] = temp;

                

                justEdit = true;
            }
            else
            {

            }
        }

        sortingProcess++;
    }
    


    ofstream finalOutput;
    finalOutput.open(outFileName);
    cout << endl << endl << "Sorting Process: " << sortingProcess << " times"<< endl << "Sorted Data: " << endl << endl;;
    for (int i = 0; i < totalLine; i++)
    {
        cout << details[i].id << " " << details[i].firstname << " " << details[i].lastname << " " << details[i].gpa << " " << details[i].major << endl;
        finalOutput << details[i].id << " " << details[i].firstname << " " << details[i].lastname << " " << details[i].gpa << " " << details[i].major << endl;
    }


    cout << endl << endl << "Your sorted file " << outFileName << " is ready! Please check your folder!" << endl << endl;
    
    
    system("pause");

}




// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
