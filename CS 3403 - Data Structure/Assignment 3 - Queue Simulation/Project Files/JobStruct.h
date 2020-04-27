#pragma once
struct Job {
	int size;
	int arrival_time;
	int waiting_time;
	int turnaround_time;

};

struct qnode
{
	Job job;
	qnode* next;
};

struct queue
{
	qnode* front;
	qnode* back;

	void Enqueue(Job j)
	{
		qnode* newnode = new qnode;
		newnode->job = j;
		newnode->next = nullptr;

		if (IsEmpty())
		{
			front = newnode;
			back = newnode;
		}
		else
		{
			back->next = newnode;
			back = newnode;
		}


	}

	void Dequeue()
	{
		//if empty do nothing
		if (!IsEmpty()) 
		{
			if (front == back)
			{
				front = nullptr;
				back = nullptr;
			}
			else
			{
				front = front->next;
			}
		}
	}

	bool IsEmpty()
	{
		if (front == nullptr) return true;
		return false;
	}

	int Size()
	{
		int size = 0;
		if (IsEmpty()) return size;

		qnode* temp = front;
		while (temp->next)
		{
			size++;
			temp = temp->next;
		}
		return size;
	}

};