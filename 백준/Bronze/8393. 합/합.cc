#include <stdio.h>
//1~n까지의 합을 구하는 프로그램
int main()
{
	int n;	//원하는 숫자와 합계를 저장할 변수
	int sum = 0;

	scanf("%d", &n);

	for (; n >= 1; n--)	//n이 1씩 감소하면 n번 만큼 반복
		sum += n;	//합계 + n

	printf("%d", sum);

	return 0;
}