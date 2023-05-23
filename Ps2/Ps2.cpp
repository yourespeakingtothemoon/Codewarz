// Ps2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
#include <queue>

long queueTime(std::vector<int> customers, int till)
{
	std::vector<int> tills(till, 0);
	for (auto customer : customers)
	{
		auto it = std::min_element(tills.begin(), tills.end());
		*it += customer;
	}
	return *std::max_element(tills.begin(), tills.end());
	
	//this works, now to write it in C#, the C++ thing was an oopsie
}
int main()
{
    std::cout << "Hello World!\n";
	std::cout << queueTime({ 10,2,3,3 }, 2);
}

/*
* There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!
input

    customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
    n: a positive integer, the number of checkout tills.

output

The function should return an integer, the total time required.

*/


