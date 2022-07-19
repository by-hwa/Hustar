// See https://aka.ms/new-console-template for more information

Console.Write("성적을 입력할 학생수를 입력하세요 : ");
String? buffer = Console.ReadLine();
int n = Convert.ToInt32(buffer);
float[] person = new float[n];

for(int i = 0;i<n;i++)
{
    // 점수 입력받기
    Console.WriteLine("person[{0}]",i);
    Console.Write("국어점수를 입력하세요: ");
    buffer = Console.ReadLine();
    int korean = Convert.ToInt32(buffer);

    Console.Write("영어점수를 입력하세요: ");
    buffer = Console.ReadLine();
    int english = Convert.ToInt32(buffer);

    Console.Write("수학점수를 입력하세요: ");
    buffer = Console.ReadLine();
    int math = Convert.ToInt32(buffer);

    int sum = korean+english+math;
    person[i] = (float)sum/3;

}

char? grade = null;
// if 문

// if(avg>=90){grade = 'A';}
// else if(avg>=80){grade = 'B';}
// else if(avg>=70){grade = 'C';}
// else if(avg>=60){grade = 'D';}
// else {grade = 'F';}


for(int i = 0;i<n;i++)
{   
    // switch 문
    switch(10-(int)person[i]/10)
    {
        case 0: 
        case 1: grade = 'A';break;
        case 2: grade = 'B';break;
        case 3: grade = 'C';break;
        case 4: grade = 'D';break;
        case 5: 
        case 6: 
        case 7: 
        case 8: 
        case 9: 
        case 10: grade = 'F';break;

        default : Console.WriteLine("잘못된 점수 !"); break;
    }

    Console.WriteLine("person[{0}]",i);
    Console.WriteLine("평균은 : {0:0.00}",person[i]);
    Console.WriteLine("학점은 : {0}",grade);
}