#pragma once
#include "Results.h";


struct CPU
{
	bool is_available;
	int job_size;

	void Acquire()
	{
		is_available = false;
	}
	void Release()
	{
		is_available = true;
	}
};

CPU cpus[4];
queue job_queue;
statistics result{};
int clock = 0;

//returns double in interval (a, b)
double GenerateRandom(double a, double b)
{
	std::random_device rd;
	std::mt19937 rng(rd());
	std::uniform_real_distribution<> dist(a, b);

	return dist(rng);
}

//returns int in interval(a, b)
int GenerateRandom(int a, int b)
{
	//overloaded Method
	std::random_device rd;
	std::mt19937 rng(rd());
	std::uniform_int_distribution<> dist(a, b);

	return dist(rng);
}

void UpdateJobQueue()
{
	qnode* temp = job_queue.front;
	while (temp)
	{
		temp->job.waiting_time++;
		if (temp->job.waiting_time == 1)
		{
			result.num_jobs_waitlisted++;
		}
		temp = temp->next;
	}

	if (job_queue.Size() > result.max_queue_size)
	{
		result.max_queue_size = job_queue.Size();
		result.time_at_max_size = 0;
		result.streak_broken = false;
	}

	if (job_queue.Size() == result.max_queue_size && !(result.streak_broken))
	{
		result.time_at_max_size++;
	}

	if (job_queue.Size() < result.max_queue_size)
	{
		result.streak_broken = true;
	}
}

void GetNewJobs()
{
	double value = GenerateRandom(0.0, 1.0);
	//40% chance of a new job
	//can get multiple new jobs per time cycle
	while (value < 0.4)
	{
		result.num_jobs++;
		int job_size = GenerateRandom(1, 10);
		Job j
		{
			job_size, clock, 0, 0
		};
		result.total_job_length += job_size;

		if (result.num_jobs == 1)
		{
			result.max_job_length = job_size;
			result.min_job_length = job_size;
		}
		else if (job_size > result.max_job_length)
		{
			result.max_job_length = job_size;
		}
		else if (job_size < result.min_job_length)
		{
			result.min_job_length = job_size;
		}
		job_queue.Enqueue(j);

		value = GenerateRandom(0.0, 1.0);
	}
}

CPU& NextAvailableCPU()
{
	for (CPU& c : cpus)
	{
		if (c.is_available) return c;
	}
}

void UpdateCPUs()
{
	for (CPU& c : cpus)
	{
		if (!(c.is_available))
		{
			c.job_size--;
			if (c.job_size == 0) c.Release();
		}
	}
}

bool CPUstatus()
{
	for (CPU& c : cpus)
	{
	if (c.is_available) return true;
	}
	return false;
}

void NextTimeCycle()
{
	GetNewJobs();

	while (CPUstatus() && !(job_queue.IsEmpty()))
	{
		CPU& cpu = NextAvailableCPU();
		cpu.Acquire();

		qnode* temp = job_queue.front;
		cpu.job_size = temp->job.size;
		result.total_wait_time += temp->job.waiting_time;
		temp->job.turnaround_time = temp->job.waiting_time + temp->job.size;
		result.total_turnaround_time += temp->job.turnaround_time;

		job_queue.Dequeue();
	}

	if (!(job_queue.IsEmpty()))
	{
		UpdateJobQueue();
	}
	UpdateCPUs();
}