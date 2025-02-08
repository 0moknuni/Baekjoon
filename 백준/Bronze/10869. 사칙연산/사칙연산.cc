#include <stdio.h>
//두 수의 사칙연산을 출력하는 프로그램
int main()
{
	int a, b;

	scanf("%d %d", &a, &b);
	printf("%d\n", a+b);
	printf("%d\n", a-b);
	printf("%d\n", a*b);
	printf("%d\n", a/b);
	printf("%d\n", a%b);
	
	return 0;
}