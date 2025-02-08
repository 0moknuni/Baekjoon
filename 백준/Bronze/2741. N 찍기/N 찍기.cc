#include <stdio.h>
//1부터 n까지 출력
int main()
{
	int n;	//사용자가 입력한 수를 저장할 변수

	scanf("%d", &n);
	
	for (int i= 1; i <= n; i++)	//1부터 n까지 n번 반복
		printf("%d\n", i);

	return 0;
}
