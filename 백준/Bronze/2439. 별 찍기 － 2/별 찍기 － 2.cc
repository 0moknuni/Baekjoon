#include <stdio.h>
//별을 출력하는 프로그램
int main()
{
	int n; //n번 반복

	scanf("%d", &n);

	for (int i = 1; n >= 1; n--) {	//n줄 출력 - 반복문에 쓸 i생성, n이 1씩 감소하며 n번 반복
		for (int j = 1; j < n; j++)	//띄어쓰기 출력
			printf(" ");
		for (int k = 1; k <= i; k++)	//별 출력 - k가 1씩 커지며 i번 반복
			printf("*");
		printf("\n");  i++;	//줄바꿈과 i++
	}

	return 0;
}