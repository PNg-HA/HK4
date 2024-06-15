#include <stdio.h>
#include <pthread.h>

// Các bi?n x1, x2, x3, x4, x5, x6
int x1, x2, x3, x4, x5, x6;

// Các bi?n w, v, y, z, ans
int w, v, y, z, ans;

pthread_mutex_t mutex; // Mutex for synchronization

// Hàm tính toán w = x1 * x2
void* compute_w(void* arg) {
    pthread_mutex_lock(&mutex);
    w = x1 * x2;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// Hàm tính toán v = x3 * x4
void* compute_v(void* arg) {
    pthread_mutex_lock(&mutex);
    v = x3 * x4;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// Hàm tính toán y = v * x5
void* compute_y(void* arg) {
    pthread_mutex_lock(&mutex);
    y = v * x5;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

// Hàm tính toán z = v * x6
void* compute_z(void* arg) {
    pthread_mutex_lock(&mutex);
    z = v * x6;
    pthread_mutex_unlock(&mutex);
    pthread_exit(NULL);
}

int main() {
    // Ð?t giá tr? cho các bi?n x1, x2, x3, x4, x5, x6
    x1 = 1;
    x2 = 2;
    x3 = 3;
    x4 = 4;
    x5 = 5;
    x6 = 6;

    // Kh?i t?o mutex
    pthread_mutex_init(&mutex, NULL);

    // Kh?i t?o các thread
    pthread_t thread_w, thread_v, thread_y, thread_z;

    // T?o thread d? tính toán w
    pthread_create(&thread_w, NULL, compute_w, NULL);

    // T?o thread d? tính toán v
    pthread_create(&thread_v, NULL, compute_v, NULL);

    // Ð?i thread w và v hoàn thành
    pthread_join(thread_w, NULL);
    pthread_join(thread_v, NULL);

    // T?o thread d? tính toán y
    pthread_create(&thread_y, NULL, compute_y, NULL);

    // T?o thread d? tính toán z
    pthread_create(&thread_z, NULL, compute_z, NULL);

    // Ð?i thread y và z hoàn thành
    pthread_join(thread_y, NULL);
    pthread_join(thread_z, NULL);

    // Tính toán ans
    pthread_mutex_lock(&mutex);
    y = w * y;
    z = w * z;
    ans = y + z;
    pthread_mutex_unlock(&mutex);

    // In k?t qu?
    printf("ans = %d\n", ans);

    // Gi?i phóng mutex
    pthread_mutex_destroy(&mutex);

    return 0;
}

