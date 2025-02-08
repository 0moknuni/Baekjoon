#include <stdio.h>
//윤년을 검사하는 프로그램
int main()
{
	unsigned int year;

	scanf("%u", &year);	//부호없는 10진 정수

	if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)	//윤년 == 4의 배수이며 100의 배수가 아니거나, 400의 배수인 년도
		printf("1");
	else
		printf("0");

	return 0;
}