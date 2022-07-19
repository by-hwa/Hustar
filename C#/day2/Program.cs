// See https://aka.ms/new-console-template for more information

// 매개변수 없이 함수를 생성
Show();

// void는 리턴되는 것이 없음
void Show(){
    Console.WriteLine("Hello World");
}

// 매개변수가 있는 함수 생성
Show1("Hello World");

void Show1(string msg){
    Console.WriteLine(msg);
}

// return 이 있는 함수 생성
Show2("Hello World");

int Show2(string msg){
    Console.WriteLine(msg);
    return 1;
}
Console.WriteLine(Show2("안녕하세요?"));

int result = 0;
result = Show2("안녕하세요!");
Console.WriteLine(result);

// 두수의 합을 수하는 함수
double sum_num(double x,double y){
    return x+y;
}

// 최대 값 구하는 함수
double max_num(double x,double y){
    if(x>y){return x;}
    else{return y;}
}

// 최소 값 구하는 함수
double min_num(double x, double y){
    if(x>y){return y;}
    else{return x;}
}

// 절대 값 구하는 함수
 double abs_num(double x){
     if(x<0){return x*-1;}
     else{return x;}
}

// string[] nums; // 배열 선언

// Console.Write("두 수를 입력하세요 !: ");
// nums = Console.ReadLine().Split(' ');
// double x = Convert.ToDouble(nums[0]);
// double y = double.Parse(nums[1]); // Convert.To 와 .Parse 와 동일함

// Console.WriteLine("두수의 합: {0}", sum_num(x,y));
// Console.WriteLine("두수 중 최대 값: {0}", max_num(x,y));
// Console.WriteLine("두수 중 최소 값: {0}", min_num(x,y));

// Console.Write("절대 값을 구할 수를 입력하세요 ! : ");
// Console.WriteLine("절대 값 : {0}", abs_num(double.Parse(Console.ReadLine())));

Log("debug");
Log("error", 4);
Log(level : 2, msg : "안녕?"); // 매개변수 이름을 지정하여 순서와 상관없이 선언 가능

void Log(string msg, byte level = 1){
    Console.WriteLine($"{msg}, {level}");
}


// 함수 오버로드

// GetNumber(111);
// GetNumber(111L);

// static void GetNumber(int num){
//     Console.WriteLine($"int : {num}");
// }
// static void GetNumber(long num){
//     Console.WriteLine($"long : {num}");
// }



// 콘솔 실행할때 입력받음

// static void main(string[] arge){

// }

// print(args[0], args[1]);
// void print(string x, string y){
//     Console.WriteLine(x);
//     Console.WriteLine(y);
// }

Console.WriteLine(Math.Pow(2,10));

// 구조체

// BusinissCard bc;

// bc.name = "Lee Byeong Hwa";
// bc.tel = "010-1234-5678";
// bc.id = 12345;

// string str = $"이름:{bc.name}\n전화번호:{bc.tel}\n아이디:{bc.id}";
// Console.WriteLine(str);
// struct BusinissCard
// {
//     public string name;
//     public string tel;
//     public int id;
// }

char a = 'A';
char b = 'a';

if(Char.IsUpper(a)){
    Console.WriteLine("{0}은 대문자",a);
}

if(Char.IsLower(b)){
    Console.WriteLine("{0}은 소문자",b);
}

Console.WriteLine("{0}",Char.ToLower(a));

// 열거형

// enum test{
//     High,
//     Nirmal,
//     Low
// }

Random random = new Random();

Console.WriteLine(random.Next()); // 범위 무작위
Console.WriteLine(random.Next(10)); // 1~10 무작위
Console.WriteLine(random.Next(1,20)); // 1~20까지 무작위

// Example.StaticMethod();
// Example ins = new Example();
// Environment.Exit(0); // 종료하는 기능

// ins.InstanceMethod(); // static 이아닌 매소드는 인스턴스를 생성하고 객체를 통해서 호출가능.

public class Example{
    static void StaticMethod(){
        Console.WriteLine("Static method");
    }
    void InstanceMethod(){
        Console.WriteLine("Instance Method");
}
}
