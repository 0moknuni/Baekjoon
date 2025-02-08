#include <stdio.h>
//n부터 1까지 출력
int main()
{
	int n;	//사용자가 입력한 수를 저장할 변수

	scanf("%d", &n);

	for (; n >= 1; n--)	//n부터 1까지 n번 반복
		printf("%d\n", n);

	return 0;
}
