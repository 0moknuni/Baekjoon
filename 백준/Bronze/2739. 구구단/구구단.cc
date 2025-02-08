#include <stdio.h>
//구구단 출력
int main()
{
	int n;	//몇 단인지 입력받은 변수

	scanf("%d", &n);

	for (int i = 1; i <= 9; i++)	//i == 1 ~ 9까지 9번 반복
		printf("%d * %d = %d\n", n, i, n*i);

	return 0;
}