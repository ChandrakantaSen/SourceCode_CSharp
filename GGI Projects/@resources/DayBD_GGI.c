#include<stdio.h>
#include<conio.h>

void main()
{
	int ch,date,year,ans;
	clrscr();
	printf("\nStep 1: Choose number between 1 to 7");
	getch();

	printf("\nStep 2: Enter your date of birth:\t");
	scanf("%d",&date);

	printf("\nStep 3: Enter last two digits of your birth year:\t");
	scanf("%d",&year);

	printf("\n--Do the Instruction--\n");
	getch();
	printf("\n1. Multiply  the choosen number with 2\n");
	getch();
	printf("\n2. Add your birth date with your answer\n");
	getch();
	printf("\n3. Substract between your answer and last two digits of your birth year (Only take +ve value)\n");
	printf("\nEnter the Final Answer:\t");
	scanf("%d",&ans);

	if(year>=ans)
	{
		ch=(((year-ans)-date)/2);
	}
	else
	{
		ch=(((year+ans)-date)/2);
	}

	switch(ch)
	{
		case 1:	printf("\nYour birthday is SUNDAY");  		break;
		case 2: printf("\nYour birthday is MONDAY");  		break;
		case 3:	printf("\nYour birthday is TUESDAY"); 		break;
		case 4:	printf("\nYour birthday is WEDNESDAY");		break;
		case 5:	printf("\nYour birthday is THURSDAY");		break;
		case 6:	printf("\nYour birthday is FRIDAY");		break;
		case 7:	printf("\nYour birthday is SATURDAY");		break;
		default: printf("\nWrong Choice");			break;
	}
	getch();
}
