#include <iostream>
#include <ctime>
#include <fstream>

using namespace std;
struct person
{
	char name[20];
	int day;
	int month;
	int year;
}person1;


int main()
{
	string firstname;
	string lastname;
	// current date/time based on current system
	time_t now = time(0);

	// convert now to string form
	char* dt = ctime(&now);
	cout << "The local date and time is: " << dt;
	// convert now to tm struct for UTC
	tm* gmtm = gmtime(&now);
	dt = asctime(gmtm);
	cout << "The UTC date and time is: " << dt << endl;

	int currentYear = gmtm->tm_year + 1900;

	cout << endl << "Please enter first name: ";
	cin >> firstname;
	cout << "Please enter last name: ";
	cin >> lastname;


	cout << endl << "Full name: " << firstname << " " << lastname << endl << endl << endl;

	cout << "Enter birth year: ";
	cin >> person1.year;
	
	if (person1.year > currentYear)
	{
	
		do {
		cout << "Birth date cannot be after " << gmtm->tm_mon + 1 << "-" << gmtm->tm_mday << "-" << currentYear << ", Please enter correct year:";
		cin >> person1.year;
	} while (person1.year > currentYear);
	}
		
	cout << "Enter birth month: ";
	
	cin >> person1.month;
	if (person1.year == currentYear)
	{
		
		do {
			cout << "Birth date cannot be after " << gmtm->tm_mon + 1 << "-" << gmtm->tm_mday << "-" << currentYear << ", Please enter correct month:";
			cin >> person1.month;
		} while (person1.month > gmtm->tm_mon + 1);
	}
	
	cout << "Enter birth date: ";
	cin >> person1.day;
	if (person1.year == currentYear && person1.month == gmtm->tm_mon + 1)
	{
		
		do {
			cout << "Birth date cannot be after " << gmtm->tm_mon + 1 << "-" << gmtm->tm_mday << "-" << currentYear << ", Please enter correct date:";
			cin >> person1.day;
		} while (person1.day > gmtm->tm_mday);
	}
	cout << endl << endl;
	cout << endl << endl << firstname << " " << lastname << "," ;
		
		
	if (person1.month > gmtm->tm_mon + 1)
	{
		cout << " age " << currentYear - person1.year - 1;
		
	}
	else if (person1.month = gmtm->tm_mon + 1)
	{
		if (person1.day >= gmtm->tm_mday - 1)
		{
			cout << " age " << currentYear - person1.year;
		}
		else
		{
			cout << " age " << currentYear - person1.year - 1;
		}
	}
	else
	{
		cout << "age " << currentYear - person1.year;
	}	

	cout << ", was born on " << person1.month << "-" << person1.day << "-" << person1.year << ", and today is ";
	
	cout << gmtm->tm_mon + 1 << "-";
	cout << gmtm->tm_mday - 1 << "-";
	cout << 1900 + gmtm->tm_year << endl;
	char c;

	cout << endl << endl;

	ofstream myfile;
	myfile.open("example.txt");
	myfile << firstname << " " << lastname << ",";


	if (person1.month > gmtm->tm_mon + 1)
	{
		myfile << " age " << currentYear - person1.year - 1;

	}
	else if (person1.month = gmtm->tm_mon + 1)
	{
		if (person1.day >= gmtm->tm_mday - 1)
		{
			myfile << " age " << currentYear - person1.year - 1;

		}
		else
		{
			myfile << " age " << currentYear - person1.year;

		}
	}
	else
	{
		myfile << "age " << currentYear - person1.year;

	}

	myfile << ", was born on " << person1.month << "-" << person1.day << "-" << person1.year << ", and today is ";
	myfile << gmtm->tm_mon + 1 << "-";
	myfile << gmtm->tm_mday + 1 << "-";
	myfile << 1900 + gmtm->tm_year << endl;

	myfile.close();
	system("pause");
	return 0;
}
