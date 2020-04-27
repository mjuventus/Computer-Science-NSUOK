/*#include <random>
#include <iostream>
#include "JobStruct.h"
#include "Results.h"
#include "Processor.h"

using namespace std;

void printResut()
{
	result.percent_jobs_waitlisted = 100 * (double)result.num_jobs_waitlisted / result.num_jobs;
	result.avg_job_length = (double)result.total_job_length / result.num_jobs;
	result.avg_wait_time = (double)result.total_wait_time / result.num_jobs;
	result.avg_turnaround_time = (double)result.total_turnaround_time / result.num_jobs;

	printf("Number of processed jobs: %d %n", result.num_jobs);
	printf("Number of jobs waitlisted: %d %n", result.num_jobs_waitlisted);
	printf("Percentage of jobs waitlisted: %5.2f Percent \n ", result.percent_jobs_waitlisted);
	printf("Average job length: %5.2f cycles \n\n", result.avg_job_length);
	printf("Longest job: %d cycles \n", result.max_job_length);
	printf("Shortest job: %d cycles \n", result.min_job_length);

	printf("Average wait time: %5.2f cycles \n", result.avg_job_time);
	printf("Average turnarounf time %5.2f cycles \n\n", result.avg_turnaround_time);
	printf("Max queue length: %d jobs \n", result.max_queue_size);
	printf("Time at max length: %d cycles \n", result.time_at_max_size);

	cin.get();
}

int main()
{
	for (CPU& c : cpus)
	{
		c.is_available = true;
	}

	while (clock < 600)
	{
		clock++;
		NextTimeCycle();
	}

	printResult();
}
*/
