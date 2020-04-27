#pragma once
struct statistics
{
	int num_jobs = 0; //Number of processed jobs
	int max_job_length;
	int min_job_length;
	int total_job_length;
	double avg_job_length;

	int total_wait_time;
	double avg_wait_time;

	int total_turnaround_time;
	double avg_turnaround_time;

	int max_queue_size;
	int time_at_max_size;
	bool streak_broken;

	int num_jobs_waitlisted;
	double percent_jobs_waitlisted;
};