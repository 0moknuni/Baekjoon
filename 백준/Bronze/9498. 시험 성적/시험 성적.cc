#include <stdio.h>
//성적 출력 프로그램
int main()
{
	int score;

	scanf("%d", &score);
	
	if (score >= 90)	
		printf("A");
	else if (80 <= score && score < 90)	//80 <= score < 90로 쓰면 올바르게 작동하지 않는다. 
		printf("B");
	else if (70 <= score && score < 80)
		printf("C");
	else if (60 <= score && score < 70)
		printf("D");
	else
		printf("F");

	return 0;
}