#include <stdio.h>

int main()
{
	int a, b, c;	

	scanf("%d %d %d", &a, &b, &c);

	printf("%d\n",  (a + b) % c );	//변수를 실수를 지정할 시 % 계산이 불가하다. 실수의 나머지 계산은 math.h의 fmod, fmodf, fmodl함수를 사용
	printf("%d\n", (a % c + b % c) % c);
	printf("%d\n", (a * b) % c);
	printf("%d\n", (a % c) * (b % c) % c);

	return 0;
}