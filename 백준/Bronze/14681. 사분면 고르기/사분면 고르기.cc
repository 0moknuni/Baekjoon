#include <stdio.h>
//점 A가 사분면 중 어디에 있는가를 검사하는 프로그램
int main()
{
	short x, y; //점 a의 좌표
	short checking_x, checking_y;	//좌표의 부호를 저장할 변수

	scanf("%hd %hd", &x, &y);	//h == short에 대한 수식, l = long에 대한 수식
	
	checking_x = (x > 0) ?1 :0;	//각 좌표가 양수인지 음수인지 체크
	checking_y = (y > 0) ?1 :0;	

	if (checking_x == 1 && checking_y == 1)	//사분면 중 어디에 속하는지 판단
		printf("1");
	else if (checking_x == 0 && checking_y == 1)
		printf("2");
	else if (checking_x == 0 && checking_y == 0)
		printf("3");
	else
		printf("4");

	return 0;
}
