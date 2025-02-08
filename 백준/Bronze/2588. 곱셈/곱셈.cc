#include <stdio.h>

int main()
{
	int a, b;	//입력 받은 수를 저장할 변수

	scanf("%d %d", &a, &b);
	
	printf("%d\n", a * (b % 10));	//일의 자리와 곱하기
	printf("%d\n", a * ((b % 100) / 10));	//십의 자리와 곱하기
	printf("%d\n", a * (b / 100));	//백의 자리와 곱하기
	printf("%d", a*b);

	return 0;
}