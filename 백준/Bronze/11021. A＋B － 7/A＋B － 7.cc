#include <stdio.h>
//두 수의 합을 구하는 프로그램
int main()
{
	int n;		//반복문 트리거
	int a, b;	//입력받은 수를 저장할 변수

	scanf("%d", &n);

	for (int i = 1; i <= n; i++) {
		scanf("%d %d", &a, &b);
		printf("Case #%d: %d\n", i, a + b);
	}

	return 0;
}