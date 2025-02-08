#include <stdio.h>
//별을 출력하는 문제
int main()
{
	int n;	//n번 만큼 별기호 줄 출력

	scanf("%d", &n);

	for (int i = 1; i <= n; i++) {
		for (int j = 1; j <= i; j++)
			printf("*");
		printf("\n");
	}

	return 0;
}