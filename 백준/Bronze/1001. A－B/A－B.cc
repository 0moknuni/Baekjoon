#include <stdio.h>
//입력받은 a-b을 출력하는 프로그램
int main()
{
	int a, b;	//두 수를 저장할 변수

	scanf("%d %d", &a, &b);
	printf("%d", a-b);

	return 0;
}