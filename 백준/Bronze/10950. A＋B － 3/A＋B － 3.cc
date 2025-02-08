#include <stdio.h>
//두 정수의 합을 출력하는 프로그램
int main()
{
	int a, b; //두 정수를 입력받을 변수
	int i;	//반복문 트리거

	scanf("%d", &i);

	for(i; i >= 1; i--) {	//i가 1씩 감소하면 i번만큼 반복
		scanf("%d %d", &a, &b);
		printf("%d\n", a + b);
	}

	return 0;
}