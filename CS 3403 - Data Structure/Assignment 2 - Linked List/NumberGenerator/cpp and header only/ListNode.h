#pragma once

using namespace std;

struct ListNode
{
	int data; 
	ListNode* next;
};

ListNode* head;
ListNode* temporary;
ListNode* newNode;

int n;
int maxSize;

ofstream writeFile;//writeFile is file object 
int SwapNumber;
const unsigned int sizeOfArray = 30;
int numberArray[sizeOfArray];