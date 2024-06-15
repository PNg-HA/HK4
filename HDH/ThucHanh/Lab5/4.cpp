#include <stdio.h>
#include <pthread.h>
#include <semaphore.h>
#include <unistd.h>
#include <iostream>
int x;
pthread_mutex_t mutex;
using namespace std;
void *ProcessA (void *arg){
	while (true){
		pthread_mutex_lock (&mutex);
		sleep(1);
		x = x +1;
		if (x == 20)
			x = 0;
		cout << "A: " << x << endl;
		pthread_mutex_unlock(&mutex);
	}
}

void *ProcessB (void *arg){
	while (true){
		pthread_mutex_lock(&mutex);
		sleep(1);
		x = x +1;
		if (x == 20){
			x = 0;
		}
		cout << "B: " << x << endl;
		pthread_mutex_unlock(&mutex);
	}
}

int main(){
	pthread_t thread1, thread2;
	pthread_mutex_init (&mutex, NULL);
	
	pthread_create (&thread1, NULL, ProcessA, NULL);
	pthread_create (&thread2, NULL, ProcessB, NULL);
	
	pthread_join(thread1,NULL);
	pthread_join(thread2,NULL);
	
	return 0;
}
