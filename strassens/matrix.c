#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <sys/time.h>
#include <math.h>

typedef struct mat_elem {
	int re, rs, ce, cs;
	float **arr;
}Matrix;

Matrix * createMatrix(int n) {
	Matrix *m1 = (Matrix *)malloc(sizeof(Matrix));
	int count = 0, i, j;
	m1->rs = 0; m1->cs = 0;
	m1->re = n - 1; m1->ce = n - 1;

	m1->arr = (float **)malloc(sizeof(float*) * n);
	m1->arr[0] = (float *)malloc(sizeof(float) * n * n);

	for (i = 0; i < n; i++) {
		m1->arr[i] = (*(m1->arr) + n * i);
	}

	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++) {
			m1->arr[i][j] = ((double)rand() / (RAND_MAX)); // OR *(*(arr+i)+j) = ++count
														   /*m1->arr[i][j] = 0.00;*/
		}
	}
	return m1;
}

void displayMatrix(Matrix *m, int n) {
	int i, j;
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++) {
			printf("%f ", m->arr[i][j]);
		}
		printf("\n");
	}
}


Matrix* Normal_Multiply(Matrix *first, Matrix *second, int n) {
	float row_sum = 0;
	int i, j, k;
	Matrix *result = createMatrix(n);

	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++) {
			for (k = 0; k < n; k++) {
				row_sum += first->arr[i][k] * second->arr[k][j];
			}
			result->arr[i][j] = row_sum;
			row_sum = 0;
		}
	}
	return result;
}

Matrix* mat_op(Matrix *m1, Matrix *m2, int n, int isAdd) {//no need to create a new matrix again, just use & to operate on the same matrix which was input as a formal parameter
	Matrix *m_result = createMatrix(n);
	int i, j;

	if (isAdd == 0) {
		for (i = 0; i<n; i++) {
			for (j = 0; j<n; j++) {
				m_result->arr[i][j] = m1->arr[i][j] + m2->arr[i][j];
			}
		}
	}
	else {
		for (i = 0; i<n; i++) {
			for (j = 0; j<n; j++) {
				m_result->arr[i][j] = m1->arr[i][j] - m2->arr[i][j];
			}
		}
	}
	return m_result;
}

Matrix* mat_add(Matrix *m1, Matrix *m2, int n) {
	return mat_op(m1, m2, n, 0);
}
Matrix* mat_sub(Matrix *m1, Matrix *m2, int n) {
	return mat_op(m1, m2, n, 1);
}

void copyArr(Matrix *dest, Matrix *source, /*int n, */int rs, int re, int cs, int ce) {
	int i, j;
	int i_dest, j_dest;
	float value;
	/*dest->rs = dest->cs = 0;
	dest->re = dest->ce = n / 2;*/

	for (i = rs, i_dest = 0; i <= re; i++, i_dest++) {
		for (j = cs, j_dest = 0; j <= ce; j++, j_dest++) {
			value = source->arr[i][j];
			dest->arr[i_dest][j_dest] = value;
		}
	}
}

Matrix* Strassen_Multiply(Matrix *m1, Matrix *m2, int n) {
	Matrix *A11, *A12, *A21, *A22, *B11, *B12, *B21, *B22;	/* Matrices for storing the given matrices split */
	Matrix *S1, *S2, *S3, *S4, *S5, *S6, *S7, *S8, *S9, *S10; /* 10 Matrices having sum or diffrences of previous 8 matrices */
	Matrix *P1, *P2, *P3, *P4, *P5, *P6, *P7;				/* Seven products */
	Matrix *C11, *C12, *C21, *C22;						/* Sub matrices of resultant matrix C*/
	Matrix *result = createMatrix(n);
	int rowCounter, colCounter, resRowCounter, resColCounter;

	/*Below variables are for base case where we have 2 x 2 matrices*/
	float a11, a12, a21, a22, b11, b12, b21, b22;
	float s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
	float p1, p2, p3, p4, p5, p6, p7;
	Matrix* BASE_C = createMatrix(2);

	/*printf("\nStrassen start\n");*/

	/* start base case calculation: perform basic multiplication to return the result of 2x2 matrix*/
	if (n <= 2) {
		/*printf("\nBase case start\n");*/
		a11 = m1->arr[0][0];
		a12 = m1->arr[0][1];
		a21 = m1->arr[1][0];
		a22 = m1->arr[1][1];

		b11 = m2->arr[0][0];
		b12 = m2->arr[0][1];
		b21 = m2->arr[1][0];
		b22 = m2->arr[1][1];

		s1 = b12 - b22;
		s2 = a11 + a12;
		s3 = a21 + a22;
		s4 = b21 - b11;
		s5 = a11 + a22;
		s6 = b11 + b22;
		s7 = a12 - a22;
		s8 = b21 + b22;
		s9 = a11 - a21;
		s10 = b11 + b12;

		p1 = a11 * s1;
		p2 = s2 * b22;
		p3 = s3 * b11;
		p4 = a22 * s4;
		p5 = s5 * s6;
		p6 = s7 * s8;
		p7 = s9 * s10;

		BASE_C->arr[0][0] = p5 + p4 - p2 + p6;
		BASE_C->arr[0][1] = p1 + p2;
		BASE_C->arr[1][0] = p3 + p4;
		BASE_C->arr[1][1] = p5 + p1 - p3 - p7;

		/*printf("\nBase case end\n");*/
		return BASE_C;
	}
	/* end base case calculation*/

	A11 = createMatrix(n / 2);
	A12 = createMatrix(n / 2);
	A21 = createMatrix(n / 2);
	A22 = createMatrix(n / 2);

	B11 = createMatrix(n / 2);
	B12 = createMatrix(n / 2);
	B21 = createMatrix(n / 2);
	B22 = createMatrix(n / 2);

	copyArr(A11, m1, m1->rs, m1->re / 2, m1->cs, m1->ce / 2);/* copy arrays based on the next block not just the same thing like this*/
	copyArr(A12, m1, m1->rs, m1->re / 2, m1->ce / 2 + 1, m1->ce);
	copyArr(A21, m1, m1->re / 2 + 1, m1->re, m1->cs, m1->ce / 2);
	copyArr(A22, m1, m1->re / 2 + 1, m1->re, m1->ce / 2 + 1, m1->ce);

	copyArr(B11, m2, m2->rs, m2->re / 2, m2->cs, m2->ce / 2);
	copyArr(B12, m2, m2->rs, m2->re / 2, m2->ce / 2 + 1, m2->ce);
	copyArr(B21, m2, m2->re / 2 + 1, m2->re, m2->cs, m2->ce / 2);
	copyArr(B22, m2, m2->re / 2 + 1, m2->re, m2->ce / 2 + 1, m2->ce);

	S1 = mat_sub(B12, B22, n / 2);
	S2 = mat_add(A11, A12, n / 2);
	S3 = mat_add(A21, A22, n / 2);
	S4 = mat_sub(B21, B11, n / 2);
	S5 = mat_add(A11, A22, n / 2);
	S6 = mat_add(B11, B22, n / 2);
	S7 = mat_sub(A12, A22, n / 2);
	S8 = mat_add(B21, B22, n / 2);
	S9 = mat_sub(A11, A21, n / 2);
	S10 = mat_add(B11, B12, n / 2);


	P1 = createMatrix(n / 2);
	P2 = createMatrix(n / 2);
	P3 = createMatrix(n / 2);
	P4 = createMatrix(n / 2);
	P5 = createMatrix(n / 2);
	P6 = createMatrix(n / 2);
	P7 = createMatrix(n / 2);

	P1 = Strassen_Multiply(A11, S1, n / 2);
	P2 = Strassen_Multiply(S2, B22, n / 2);
	P3 = Strassen_Multiply(S3, B11, n / 2);
	P4 = Strassen_Multiply(A22, S4, n / 2);
	P5 = Strassen_Multiply(S5, S6, n / 2);
	P6 = Strassen_Multiply(S7, S8, n / 2);
	P7 = Strassen_Multiply(S9, S10, n / 2);

	C11 = createMatrix(n / 2);
	C12 = createMatrix(n / 2);
	C21 = createMatrix(n / 2);
	C22 = createMatrix(n / 2);

	C11 = mat_add(mat_sub(mat_add(P5, P4, n / 2), P2, n / 2), P6, n / 2);
	C12 = mat_add(P1, P2, n / 2);
	C21 = mat_add(P3, P4, n / 2);
	C22 = mat_sub(mat_sub(mat_add(P1, P5, n / 2), P3, n / 2), P7, n / 2);

	for (rowCounter = C11->rs, resRowCounter = 0; rowCounter <= C11->re; rowCounter++, resRowCounter++) {
		for (colCounter = C11->cs, resColCounter = 0; colCounter <= C11->ce; colCounter++, resColCounter++) {
			result->arr[resRowCounter][resColCounter] = C11->arr[rowCounter][colCounter];
		}
	}

	for (rowCounter = C12->rs, resRowCounter = 0; rowCounter <= C12->re; rowCounter++, resRowCounter++) {
		for (colCounter = C12->cs, resColCounter = n / 2; colCounter <= C12->ce; colCounter++, resColCounter++) {
			result->arr[resRowCounter][resColCounter] = C12->arr[rowCounter][colCounter];
		}
	}

	for (rowCounter = C21->rs, resRowCounter = n / 2; rowCounter <= C21->re; rowCounter++, resRowCounter++) {
		for (colCounter = C21->cs, resColCounter = 0; colCounter <= C21->ce; colCounter++, resColCounter++) {
			result->arr[resRowCounter][resColCounter] = C21->arr[rowCounter][colCounter];
		}
	}

	for (rowCounter = C22->rs, resRowCounter = n / 2; rowCounter <= C22->re; rowCounter++, resRowCounter++) {
		for (colCounter = C22->cs, resColCounter = n / 2; colCounter <= C22->ce; colCounter++, resColCounter++) {
			result->arr[resRowCounter][resColCounter] = C22->arr[rowCounter][colCounter];
		}
	}

	/*printf("\nStrassen end\n");*/
	return result;
}

struct timeval GetTimeStamp() {
	struct timeval tv;
	gettimeofday(&tv, NULL);
	return tv;
}


int main(void) {
	int n, i, j;
	Matrix *mat1, *mat2, *normal_product, *strassen_product;
	/*time_t tn_start, tn_end, ts_start, ts_end;*/
	long int tn_diff, ts_diff;
	struct timespec tn_start, tn_end, ts_start, ts_end;
	/*	struct timeval tss_start, tss_end, tnn_start, tnn_end;*/

	for (i = 1; i <= 3; i++) {
		n = pow(2, i);

		mat1 = createMatrix(n);
		mat2 = createMatrix(n);

		/*tn_start = time(NULL);*/
		/*tn_start = GetTimeStamp();*/
		clock_gettime(CLOCK_MONOTONIC, &tn_start);
		normal_product = Normal_Multiply(mat1, mat2, n);
		clock_gettime(CLOCK_MONOTONIC, &tn_end);
		/*tn_end = GetTimeStamp();
		displayMatrix(normal_product, n);
		tn_end = time(NULL);
		tn_diff = difftime(tn_end, tn_start);*/
		tn_diff = ((tn_end.tv_nsec - tn_start.tv_nsec)) / CLOCKS_PER_SEC;

		printf("\nProduct by normal method for n = %d:\n", n);
		displayMatrix(normal_product, n);


		/*ts_start = time(NULL);
		ts_start = GetTimeStamp();*/
		clock_gettime(CLOCK_MONOTONIC, &ts_start);
		strassen_product = Strassen_Multiply(mat1, mat2, n);
		/*ts_end = time(NULL);
		ts_end = GetTimeStamp();*/
		clock_gettime(CLOCK_MONOTONIC, &ts_end);
		/*ts_diff = difftime(ts_end, ts_start);*/
		ts_diff = ((ts_end.tv_nsec - ts_start.tv_nsec)) / CLOCKS_PER_SEC;
		


		printf("\nProduct by normal method for n = %d:\n", n);
		displayMatrix(strassen_product, n);

		free(strassen_product);
		free(normal_product);

		free(mat1);
		free(mat2);
	}
	return 0;
}
