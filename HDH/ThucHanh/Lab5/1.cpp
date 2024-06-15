#include <iostream>
#include <semaphore.h>
#include <pthread.h>
#include <unistd.h>

using namespace std;

sem_t sem;
int sell, product;

void *sellFunc(void *arg){
	while (true){
		sleep(1);
		sem_wait(&sem);
		sell++;
		cout << "Sell: " << sell << endl;
	}
}

void *productFunc (void *arg){
	while (true){
		if (product < sell + 86 + 10) {
			sleep (1);
			product++;
			cout << "Product: " << product << endl;
			sem_post(&sem);
		}
	}
}

int main(){
	sem_init (&sem, 0, 0);
	pthread_t thread;
	pthread_create (&thread, NULL, sellFunc, NULL);
	pthread_create (&thread, NULL, productFunc, NULL);
	pthread_join (thread, NULL);
	sem_destroy (&sem);
	return 0;
}
