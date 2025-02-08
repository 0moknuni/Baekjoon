#include <stdio.h>
//설정 시간에서 45분을 빼는 프로그램
int main()
{
	int hour, min;	//시간과 분을 저장할 변수

	scanf("%d %d", &hour, &min);

	if (min >= 45)
		printf("%d %d", hour, min-45);
	else {	//min<45
		if (hour == 0)	//00시 - 1시간 = 23시 
			printf("%d %d", 23, min + 15);
		else
			printf("%d %d", hour - 1, min + 15);
	}

	return 0;
}