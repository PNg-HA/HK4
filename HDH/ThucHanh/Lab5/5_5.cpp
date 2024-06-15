#include <stdio.h>
#include <pthread.h>

// C�c bi?n x1, x2, x3, x4, x5, x6
int x1, x2, x3, x4, x5, x6;

// C�c bi?n w, v, y, z, ans
int w, v, y, z, ans;

pthread_mutex_t mutex; // Mutex for synchronization

// H�m t�nh to�n w = x1 * x2
void* compute_w(void* arg) {
    pthread_mutex_lock(&mutex);
    w = x1 * x2;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// H�m t�nh to�n v = x3 * x4
void* compute_v(void* arg) {
    pthread_mutex_lock(&mutex);
    v = x3 * x4;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// H�m t�nh to�n y = v * x5
void* compute_y(void* arg) {
    pthread_mutex_lock(&mutex);
    y = v * x5;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// H�m t�nh to�n z = v * x6
void* compute_z(void* arg) {
    pthread_mutex_lock(&mutex);
    z = v * x6;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

int main() {
    // �?t gi� tr? cho c�c bi?n x1, x2, x3, x4, x5, x6
    x1 = 1;
    x2 = 2;
    x3 = 3;
    x4 = 4;
    x5 = 5;
    x6 = 6;

    // Kh?i t?o mutex
    pthread_mutex_init(&mutex, NULL);

    // Kh?i t?o c�c thread
    pthread_t thread_w, thread_v, thread_y, thread_z;

    // T?o thread d? t�nh to�n w
    pthread_create(&thread_w, NULL, compute_w, NULL);

    // T?o thread d? t�nh to�n v
    pthread_create(&thread_v, NULL, compute_v, NULL);

    // �?i thread w v� v ho�n th�nh
    pthread_join(thread_w, NULL);
    pthread_join(thread_v, NULL);

    // T?o thread d? t�nh to�n y
    pthread_create(&thread_y, NULL, compute_y, NULL);

    // T?o thread d? t�nh to�n z
    pthread_create(&thread_z, NULL, compute_z, NULL);

    // �?i thread y v� z ho�n th�nh
    pthread_join(thread_y, NULL);
    pthread_join(thread_z, NULL);

    // T�nh to�n ans
    pthread_mutex_lock(&mutex);
    y = w * y;
    z = w * z;
    ans = y + z;
    pthread_mutex_unlock(&mutex);

    // In k?t qu?
    printf("ans = %d\n", ans);

    // Gi?i ph�ng mutex
    pthread_mutex_destroy(&mutex);

    return 0;
}

