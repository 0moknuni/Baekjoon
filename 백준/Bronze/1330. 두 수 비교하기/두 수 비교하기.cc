#include <stdio.h>
//두 수를 비교하는 프로그램
int main()
{
	int a, b;	//입력받은 두 수를 저장할 변수

	scanf("%d %d", &a, &b);

	if (a > b)
		printf(">");
	else if (a == b)
		printf("==");
	else
		printf("<");

	return 0;
}