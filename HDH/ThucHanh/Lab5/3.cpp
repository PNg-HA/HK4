#include <iostream>
#include <semaphore.h>
#include <pthread.h>
#include <unistd.h>

int x;

void *ProcessA(void *arg){
	while (true){
		sleep(1);
		x = x +1;
		if (x == 20);
			x = 0;
		std:: cout << "A: " << x << std:: endl;
	}
}

void *ProcessB(void *arg){
	while (true){
		sleep(1);
		x = x +1;
		if (x==20)
			x = 0;
		std:: cout << "B: " << x << std::endl;
	}
}

int main(){
	pthread_t thread1, thread2;
	
	pthread_create(&thread1, NULL, ProcessA, NULL);
	pthread_create(&thread1, NULL, ProcessB, NULL);
	
	pthread_join(thread1, NULL);
	pthread_join(thread2, NULL);
	
	return 0;
}
