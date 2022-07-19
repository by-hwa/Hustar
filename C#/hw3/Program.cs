// See https://aka.ms/new-console-template for more information


// 계산기
Calculater cal = new Calculater();

Person[] person = new Person[5];


for(int i = 0;i<5;i++){
    Console.WriteLine("이름 도서대출id 나이 전화번호 를 ' '로 구분하여 입력하세요");
    string[] buffer1 = Console.ReadLine().Split(' ');
    person[i] = new Person(buffer1[0],buffer1[1],Convert.ToInt32(buffer1[2]),Convert.ToInt32(buffer1[3]));
}


Console.Write("검색할 사람의 이름을 입력하세요: ");
string buffer2 = Console.ReadLine();

for(int i = 0;i<5;i++){
    if(buffer2==person[i].get_name()){person[i].show_info();}
}

public class Calculater{
    private Double num1, num2, result;
    private string? operater;

    public Calculater(){
        Console.WriteLine("연산자 : + - * / % abs ^ q");
        Console.Write("숫자를 입력하세요 : ");
        string? buffer = Console.ReadLine();
        num1 = Convert.ToDouble(buffer);
        this.Get_op();
    }

    public void Get_op(){
        Console.Write("연산자를 입력하세요 : ");
        string? buffer = Console.ReadLine();
        if(buffer!="q"){this.Get_val(buffer);}
    }

    public void Get_val(string operater){
        this.operater=operater;
        if(operater == "abs"){this.Calculate();}
        else{
            Console.Write("숫자를 입력하세요 : ");
            string? buffer = Console.ReadLine();
            double num = Convert.ToDouble(buffer);
            Get_val(num);
        }
    }
    public void Get_val(Double num){this.num2 = num;this.Calculate();}

    public void Calculate(){
        if(this.operater=="abs"){
            this.result=Math.Abs(this.num1);
            Console.WriteLine("{0}의 절대값은 {1}입니다.",num1,result);
            num1 = result;
        }
        else if(this.operater=="+"){
            this.result = this.num1 + this.num2;
            Console.WriteLine("{0}+{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="+"){
            this.result = this.num1 + this.num2;
            Console.WriteLine("{0}+{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="-"){
            this.result = this.num1 - this.num2;
            Console.WriteLine("{0}-{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="*"){
            this.result = this.num1 * this.num2;
            Console.WriteLine("{0}*{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="/"){
            if(num2==0){Console.WriteLine("0으로 나눌 수 없습니다.");num2=1;}
            this.result = this.num1 / this.num2;
            Console.WriteLine("{0}/{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="%"){
            this.result = this.num1 % this.num2;
            Console.WriteLine("{0}%{1}={2}",num1,num2,result);
            num1 = result;
        }
        else if(this.operater=="^"){
            this.result = Math.Pow(this.num1, this.num2);
            Console.WriteLine("{0}^{1}={2}",num1,num2,result);
            num1 = result;
        }
        else{Console.WriteLine("잘못된 값이 입력되었습니다.");}
        this.Get_op();
    }
}

// 도서계산 프로그램

public class Person{
    string? name, id;
    int age, tel;

    public Person(){
        this.name = "이름없음";
        this.id = "a0000";
        this.age = 17;
        this.tel = 01012345678;
    }

    public Person(string name, string id, int age, int tel){
        this.name = name;
        this.id = id;
        this.age = age;
        this.tel = tel;
    }

    public string get_name(){return this.name;}
    
    public void show_info(){
        Console.WriteLine("이름 : {0} 나이 : {1} 도서대출 id : {2} 전화번호 : {3}",this.name,this.age,this.id,this.tel);
        }
}

