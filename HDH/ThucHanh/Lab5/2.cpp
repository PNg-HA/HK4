#include <iostream>
#include <semaphore.h>
#include <pthread.h>
#include <unistd.h>
#include <vector>
#include <cstdlib>
#include <ctime> // for time()
using namespace std;

vector <int> my_array;
sem_t sem;

void *create_number (void *arg){
	srand(time(NULL));
	while (1){
		int number = rand() % 100;
		my_array.push_back(number);
		cout << "(1): \t";
		for (int i = 0; i < my_array.size(); i++){
			cout << my_array[i] << "\t";
		}
		cout << "\n size(1): " << my_array.size() << endl;
		sem_post(&sem);
		sleep(1);
	}
}

void *delete_number (void* arg){
	while (1){
		sem_wait(&sem);
		if (my_array.size() == 0){
			cout << "Nothing in the array!" << endl;
		}
		else {
			my_array.pop_back();
			cout << "(2): \t";
			for (int i = 0; i < my_array.size(); i++){
				cout << my_array[i] << "\t";
			}
			cout << "\n size(2): " << my_array.size() << endl;
		}
		sleep(2);
	}
}
int main(){
	sem_init(&sem, 1, 0);
	
	pthread_t thread1, thread2;
	pthread_create (&thread1, NULL, create_number, NULL);
	pthread_create(&thread2,NULL, delete_number, NULL);
	pthread_join(thread1, NULL);
	pthread_join (thread2, NULL);
	
	sem_destroy(&sem);
	return 0;
}
