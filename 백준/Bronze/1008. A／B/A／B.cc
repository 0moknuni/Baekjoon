#include <stdio.h>
//입력받은 a/b을 출력하는 프로그램
int main()
{
	double a, b;	//두 수를 저장할 변수

	scanf("%lf %lf", &a, &b);
	printf("%.9lf", a/b);

	return 0;
}